using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ControllerEmu {
    public delegate int KeyHookProc(int code, int wParam, ref KeyHookData lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct KeyHookData {
        public uint vkCode;
        public uint scanCode;
        public KeyHookDataFlags flags;
        public uint time;
        public UIntPtr dwExtraInfo;
    }

    [Flags]
    public enum KeyHookDataFlags : uint {
        LLKHF_EXTENDED = 0x01,
        LLKHF_INJECTED = 0x10,
        LLKHF_ALTDOWN = 0x20,
        LLKHF_UP = 0x80,
    }

    public enum KeyState : int {
        VKeyDown = 0x0000,
        VKeyExtended = 0x0001,
        VKeyUp = 0x0002,
        KeyDown = 0x100,
        KeyUp = 0x101,
        SysKeyDown = 0x104,
        SysKeyUp = 0x105
    }

    public class KeyHookEventArgs : HandledEventArgs {
        public Keys Key { get; private set; }
        public KeyState KeyState { get; private set; }

        public KeyHookEventArgs(Keys key, KeyState keyState) {
            Key = key;
            KeyState = keyState;
        }
    }

    public class KeyPressEventArgs : HandledEventArgs {
        public Binding Binding { get; private set; }

        public KeyPressEventArgs(Binding binding) {
            Binding = binding;
        }
    }

    public class AxisPosEventArgs : HandledEventArgs {
        public Point AxisPos { get; private set; }

        public AxisPosEventArgs(Point axisPos) {
            AxisPos = axisPos;
        }
    }

    public class Binding {
        public Buttons Button { get; set; }
        public Keys Key { get; set; }
        public bool Pressed { get; set; }
        public bool Updating { get; set; }
    }

    public enum Buttons {
        ToggleA, ToggleB, Up, Down, Left, Right, A, B, X, Y, L1, L2, R1, R2, Start, Back
    }

    public class InputHook {
        protected IntPtr KeyHook = IntPtr.Zero;
        protected KeyHookProc KeyHookDelegate;

        public event EventHandler<EventArgs> EmuBindingUpdated;
        public event EventHandler<EventArgs> SkillBindingsUpdated;
        public event EventHandler<KeyPressEventArgs> StateChanged;
        public event EventHandler<KeyPressEventArgs> KeyPress;
        public event EventHandler<AxisPosEventArgs> AxisUpdate;
        public event EventHandler<EventArgs> AxisReturn;

        public const short MIN_AXIS = -32768;
        public const short MAX_AXIS = 32767;
        public const byte MIN_SLIDER = 0;
        public const byte MAX_SLIDER = 255;

        public bool Active = false;
        public bool UpdatingEmuBindings = false;
        public bool UpdatingSkillBindings = false;

        public List<Binding> EmuBindings;
        public List<Binding> SkillBindings;

        private enum HookID : int {
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }

        public InputHook() {
            Hook();

            EmuBindings = new List<Binding>() {
                new Binding { Button = Buttons.ToggleA, Key = Config.Binding.ToggleA },
                new Binding { Button = Buttons.ToggleB, Key = Config.Binding.ToggleB },
                new Binding { Button = Buttons.Up, Key = Config.Binding.Up },
                new Binding { Button = Buttons.Down, Key = Config.Binding.Down },
                new Binding { Button = Buttons.Left, Key = Config.Binding.Left },
                new Binding { Button = Buttons.Right, Key = Config.Binding.Right },
                new Binding { Button = Buttons.A, Key = Config.Binding.A },
                new Binding { Button = Buttons.B, Key = Config.Binding.B },
                new Binding { Button = Buttons.X, Key = Config.Binding.X },
                new Binding { Button = Buttons.Y, Key = Config.Binding.Y },
                new Binding { Button = Buttons.L1, Key = Config.Binding.L1 },
                new Binding { Button = Buttons.L2, Key = Config.Binding.L2},
                new Binding { Button = Buttons.R1, Key = Config.Binding.R1 },
                new Binding { Button = Buttons.R2, Key = Config.Binding.R2 },
                new Binding { Button = Buttons.Start, Key = Config.Binding.Start },
                new Binding { Button = Buttons.Back, Key = Config.Binding.Back },
            };

            SkillBindings = new List<Binding>();
            foreach(Keys key in Config.Binding.SkillBindings) {
                SkillBindings.Add(new Binding { Key = key });
            }
        }

        ~InputHook() { Unhook(); }

        private void Hook() {
            IntPtr hInstance = WinApi.LoadLibrary("User32");

            KeyHookDelegate = new KeyHookProc(KeyHookProc);
            KeyHook = WinApi.SetWindowsHookEx((int)HookID.WH_KEYBOARD_LL, KeyHookDelegate, hInstance, 0);
        }

        public virtual void Unhook() {
            WinApi.UnhookWindowsHookEx(KeyHook);
        }

        private int KeyHookProc(int code, int wParam, ref KeyHookData lParam) {
            if(code >= 0) {
                Keys key = (Keys)lParam.vkCode;
                KeyState state = (KeyState)wParam;

                if(UpdatingEmuBindings || UpdatingSkillBindings) {
                    if(state == KeyState.KeyUp) {
                        if(UpdatingEmuBindings) {
                            UpdatingEmuBindings = false;

                            Binding binding = EmuBindings.Find(x => x.Updating == true);
                            if(binding != null) {
                                binding.Updating = false;

                                if(key == Keys.Escape) {
                                    binding.Key = Keys.None;
                                } else {
                                    Binding alreadySet = EmuBindings.Find(x => x.Key == key && x.Button != binding.Button);
                                    if(alreadySet != null) {
                                        alreadySet.Key = Keys.None;
                                    }
                                    binding.Key = key;
                                }

                                EmuBindingUpdated(this, new EventArgs());
                            }
                        } else {
                            UpdatingSkillBindings = false;

                            Binding binding = SkillBindings.Find(x => x.Key == key);
                            if(binding == null) {
                                SkillBindings.Add(new Binding { Key = key });
                            } else {
                                SkillBindings.Remove(binding);
                            }

                            SkillBindingsUpdated(this, new EventArgs());
                        }
                    }
                    return -1;
                } else {
                    IntPtr hWnd = WinApi.GetForegroundWindow();
                    string winTitle = WinApi.GetWindowTitle(hWnd).ToLower();
                    bool clientActive = winTitle.StartsWith(Config.General.ClientTitle.ToLower());

                    Binding boundKey = EmuBindings.Find(x => x.Key == key && x.Key != Keys.None);
                    if(boundKey != null) {
                        if(clientActive) {
                            if(boundKey.Button == Buttons.ToggleA || boundKey.Button == Buttons.ToggleB) {
                                boundKey.Pressed = state == KeyState.KeyDown;
                                if(state == KeyState.KeyUp) {
                                    Active = !Active;
                                    StateChanged(this, new KeyPressEventArgs(boundKey));
                                }
                                if((boundKey.Button == Buttons.ToggleA && !Config.General.ToggleAPassthrough) || (boundKey.Button == Buttons.ToggleB && !Config.General.ToggleBPassthrough)) {
                                    return -1;
                                }
                            } else if(Active) {
                                boundKey.Pressed = state == KeyState.KeyDown;
                                KeyPress(this, new KeyPressEventArgs(boundKey));
                                if(!Config.General.OverridePassthrough) {
                                    return -1;
                                }
                            }
                        } else if(state == KeyState.KeyUp && boundKey.Pressed) {
                            boundKey.Pressed = false;

                            if((boundKey.Button != Buttons.ToggleA || !Config.General.ToggleAPassthrough) && (boundKey.Button != Buttons.ToggleB || !Config.General.ToggleBPassthrough)) {
                                return -1;
                            }
                        }
                    } else if(clientActive && Active) {
                        boundKey = SkillBindings.Find(x => x.Key == key && x.Key != Keys.None);
                        if(boundKey != null) {
                            if(state == KeyState.KeyDown) {
                                WinApi.GetWindowRect(hWnd, out WinApi.RECT clientRect);
                                Size halfRes = new Size(clientRect.Width / 2, clientRect.Height / 2);
                                Point relativePos = new Point(Cursor.Position.X - clientRect.X, Cursor.Position.Y - clientRect.Y);
                                Point midOffset = new Point(relativePos.X - halfRes.Width, relativePos.Y - halfRes.Height);
                                Point axisTranslation = new Point((int)((float)midOffset.X / halfRes.Width * MAX_AXIS), (int)-((float)midOffset.Y / halfRes.Height * MAX_AXIS));

                                AxisUpdate(this, new AxisPosEventArgs(axisTranslation));
                            } else {
                                AxisReturn(this, new EventArgs());
                            }
                        }
                    }
                }
            }

            return WinApi.CallNextHookEx(KeyHook, code, wParam, ref lParam);
        }
    }
}
