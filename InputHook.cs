using System;
using System.ComponentModel;
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

    public class InputHook {
        protected IntPtr KeyHook = IntPtr.Zero;
        protected KeyHookProc KeyHookDelegate;

        public event EventHandler<KeyHookEventArgs> ToggleKeyUpdated;
        public event EventHandler<EventArgs> StateChanged;
        public event EventHandler<KeyHookEventArgs> KeyPress;

        public bool Enabled { get; set; } = false;
        public bool Active { get; set; } = false;
        public bool UpdatingToggleKey { get; set; } = false;

        public bool CtrlDown { get; set; } = false;
        public bool ShiftDown { get; set; } = false;
        public bool AltDown { get; set; } = false;

        private Keys ToggleKey = Keys.Oem8; //Tilde key on UK keyboard
        private bool ToggleKeyDown = false;
        private bool WDown = false;
        private bool ADown = false;
        private bool SDown = false;
        private bool DDown = false;

        private enum HookID : int {
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }

        public InputHook(int toggleKeyCode) {
            Hook();
            ToggleKey = (Keys)toggleKeyCode;
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
            if(code >= 0 && (Enabled || UpdatingToggleKey)) {
                Keys key = (Keys)lParam.vkCode;
                KeyState state = (KeyState)wParam;

                if(UpdatingToggleKey) {
                    if(state == KeyState.KeyUp) {
                        UpdatingToggleKey = false;
                        ToggleKey = key;
                        ToggleKeyUpdated(this, new KeyHookEventArgs(key, KeyState.KeyUp));
                        return -1;
                    } else {
                        return -1;
                    }
                } else {
                    string winTitle = WinApi.GetWindowTitle(WinApi.GetForegroundWindow());
                    bool clientActive = winTitle.Contains(Config.General.ClientTitle);

                    if(key == Keys.LControlKey) {
                        CtrlDown = state == KeyState.KeyDown;
                    } else if(key == Keys.LShiftKey) {
                        ShiftDown = state == KeyState.KeyDown;
                    } else if(key == Keys.LMenu) {
                        AltDown = state == KeyState.KeyDown;
                    }

                    if(clientActive && !CtrlDown && !ShiftDown && !AltDown) {
                        if(key == ToggleKey) {
                            ToggleKeyDown = state == KeyState.KeyDown;
                            if(state == KeyState.KeyUp) {
                                Active = !Active;
                                StateChanged(this, new EventArgs());
                            }
                            return -1;
                        } else if(key == Keys.W && Active) {
                            WDown = state == KeyState.KeyDown;
                            KeyPress(this, new KeyHookEventArgs(key, state));
                            return -1;
                        } else if(key == Keys.A && Active) {
                            ADown = state == KeyState.KeyDown;
                            KeyPress(this, new KeyHookEventArgs(key, state));
                            return -1;
                        } else if(key == Keys.S && Active) {
                            SDown = state == KeyState.KeyDown;
                            KeyPress(this, new KeyHookEventArgs(key, state));
                            return -1;
                        } else if(key == Keys.D && Active) {
                            DDown = state == KeyState.KeyDown;
                            KeyPress(this, new KeyHookEventArgs(key, state));
                            return -1;
                        }
                    } else {
                        if(key == ToggleKey && state == KeyState.KeyUp && ToggleKeyDown) {
                            ToggleKeyDown = false;
                            return -1;
                        } else if(key == Keys.W && state == KeyState.KeyUp && WDown) {
                            if(clientActive) {
                                KeyPress(this, new KeyHookEventArgs(key, state));
                            }
                            WDown = false;
                            return -1;
                        } else if(key == Keys.A && state == KeyState.KeyUp && ADown) {
                            if(clientActive) {
                                KeyPress(this, new KeyHookEventArgs(key, state));
                            }
                            ADown = false;
                            return -1;
                        } else if(key == Keys.S && state == KeyState.KeyUp && SDown) {
                            if(clientActive) {
                                KeyPress(this, new KeyHookEventArgs(key, state));
                            }
                            SDown = false;
                            return -1;
                        } else if(key == Keys.D && state == KeyState.KeyUp && DDown) {
                            if(clientActive) {
                                KeyPress(this, new KeyHookEventArgs(key, state));
                            }
                            DDown = false;
                            return -1;
                        }
                    }
                }
            }

            return WinApi.CallNextHookEx(KeyHook, code, wParam, ref lParam);
        }
    }
}
