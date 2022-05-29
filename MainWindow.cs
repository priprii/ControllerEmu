using System;
using System.Windows.Forms;
using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using Pri.Forms;

namespace ControllerEmu {
    public partial class MainWindow : PriForm {
        private InputHook InputHook;
        private ViGEmClient Client;
        private IXbox360Controller Controller;

        private const short MIN_AXIS = -32768;
        private const short MAX_AXIS = 32767;
        private const byte MIN_SLIDER = 0;
        private const byte MAX_SLIDER = 255;
        private short xPos = 0;
        private short yPos = 0;

        public MainWindow() {
            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            Config.Load();
            InitializeConfig();

            InputHook = new InputHook();
            InputHook.BindingUpdated += InputHook_BindingUpdated;
            InputHook.StateChanged += InputHook_StateChanged;
            InputHook.KeyPress += InputHook_KeyPress;

            ToggleController(true);
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                TrayCMenu.Show(Cursor.Position);
            }
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            if(WindowState == FormWindowState.Minimized) { Hide(); }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
            if(Controller != null) { Controller.Disconnect(); Controller = null; }
            if(Client != null) { Client.Dispose(); Client = null; }
            InputHook.Unhook();
            Audio.StopMediaManager();
        }

        private void InputHook_BindingUpdated(object sender, EventArgs e) {
            Config.Binding.ToggleA = InputHook.Bindings.Find(x => x.Button == Buttons.ToggleA).Key;
            Config.Binding.ToggleB = InputHook.Bindings.Find(x => x.Button == Buttons.ToggleB).Key;
            Config.Binding.Up = InputHook.Bindings.Find(x => x.Button == Buttons.Up).Key;
            Config.Binding.Down = InputHook.Bindings.Find(x => x.Button == Buttons.Down).Key;
            Config.Binding.Left = InputHook.Bindings.Find(x => x.Button == Buttons.Left).Key;
            Config.Binding.Right = InputHook.Bindings.Find(x => x.Button == Buttons.Right).Key;
            Config.Binding.A = InputHook.Bindings.Find(x => x.Button == Buttons.A).Key;
            Config.Binding.B = InputHook.Bindings.Find(x => x.Button == Buttons.B).Key;
            Config.Binding.X = InputHook.Bindings.Find(x => x.Button == Buttons.X).Key;
            Config.Binding.Y = InputHook.Bindings.Find(x => x.Button == Buttons.Y).Key;
            Config.Binding.L1 = InputHook.Bindings.Find(x => x.Button == Buttons.L1).Key;
            Config.Binding.L2 = InputHook.Bindings.Find(x => x.Button == Buttons.L2).Key;
            Config.Binding.R1 = InputHook.Bindings.Find(x => x.Button == Buttons.R1).Key;
            Config.Binding.R2 = InputHook.Bindings.Find(x => x.Button == Buttons.R2).Key;
            Config.Binding.Start = InputHook.Bindings.Find(x => x.Button == Buttons.Start).Key;
            Config.Binding.Back = InputHook.Bindings.Find(x => x.Button == Buttons.Back).Key;
            Config.Save();

            InitializeConfig();
        }

        private void InputHook_StateChanged(object sender, KeyPressEventArgs e) {
            if((e.Binding.Button == Buttons.ToggleA && Config.General.ToggleAAudio) || (e.Binding.Button == Buttons.ToggleB && Config.General.ToggleBAudio)) {
                if(InputHook.Active && Config.General.EnabledAudioVolume > 0) {
                    Audio.Play(Config.General.EnabledAudioFile, Config.General.EnabledAudioVolume);
                } else if(!InputHook.Active && Config.General.DisabledAudioVolume > 0) {
                    Audio.Play(Config.General.DisabledAudioFile, Config.General.DisabledAudioVolume);
                }
            }
        }

        private void InputHook_KeyPress(object sender, KeyPressEventArgs e) {
            switch(e.Binding.Button) {
                case Buttons.Up:
                    if(!e.Binding.Pressed && yPos == MAX_AXIS) {
                        yPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    } else if(e.Binding.Pressed) {
                        yPos = MAX_AXIS;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    }
                    break;
                case Buttons.Down:
                    if(!e.Binding.Pressed && yPos == MIN_AXIS) {
                        yPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    } else if(e.Binding.Pressed) {
                        yPos = MIN_AXIS;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    }
                    break;
                case Buttons.Left:
                    if(!e.Binding.Pressed && xPos == MIN_AXIS) {
                        xPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    } else if(e.Binding.Pressed) {
                        xPos = MIN_AXIS;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    }
                    break;
                case Buttons.Right:
                    if(!e.Binding.Pressed && xPos == MAX_AXIS) {
                        xPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    } else if(e.Binding.Pressed) {
                        xPos = MAX_AXIS;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    }
                    break;
                case Buttons.A: Controller.SetButtonState(Xbox360Button.A, e.Binding.Pressed); break;
                case Buttons.B: Controller.SetButtonState(Xbox360Button.B, e.Binding.Pressed); break;
                case Buttons.X: Controller.SetButtonState(Xbox360Button.X, e.Binding.Pressed); break;
                case Buttons.Y: Controller.SetButtonState(Xbox360Button.Y, e.Binding.Pressed); break;
                case Buttons.L1: Controller.SetButtonState(Xbox360Button.LeftShoulder, e.Binding.Pressed); break;
                case Buttons.L2: Controller.SetSliderValue(Xbox360Slider.LeftTrigger, e.Binding.Pressed ? MAX_SLIDER : MIN_SLIDER); break;
                case Buttons.R1: Controller.SetButtonState(Xbox360Button.RightShoulder, e.Binding.Pressed); break;
                case Buttons.R2: Controller.SetSliderValue(Xbox360Slider.RightTrigger, e.Binding.Pressed ? MAX_SLIDER : MIN_SLIDER); break;
                case Buttons.Back: Controller.SetButtonState(Xbox360Button.Back, e.Binding.Pressed); break;
                case Buttons.Start: Controller.SetButtonState(Xbox360Button.Start, e.Binding.Pressed); break;
            }
        }

        private void ToggleController(bool enable) {
            if(enable) {
                Client = new ViGEmClient();
                Controller = Client.CreateXbox360Controller();
                Controller.Connect();
            } else {
                Controller.Disconnect();
                Controller = null;
                Client.Dispose();
                Client = null;
            }

            TrayCMenuToggleConnect.Text = enable ? "Disconnect Controller" : "Connect Controller";
            InputHook.Active = false;
        }

        private void TrayCMenuToggleConnect_Click(object sender, EventArgs e) {
            if(Client == null || Controller == null) {
                ToggleController(true);
            } else {
                ToggleController(false);
            }
        }
        private void TrayCMenuExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void TrayCMenuReloadConfig_Click(object sender, EventArgs e) {
            Config.Load();
            InitializeConfig();
        }
        private void InitializeConfig() {
            ToggleAPassthrough.Checked = Config.General.ToggleAPassthrough;
            ToggleBPassthrough.Checked = Config.General.ToggleBPassthrough;
            ToggleAAudio.Checked = Config.General.ToggleAAudio;
            ToggleBAudio.Checked = Config.General.ToggleBAudio;
            ClientTitle.Text = Config.General.ClientTitle;
            EnabledVolume.Value = (decimal)Config.General.EnabledAudioVolume;
            DisabledVolume.Value = (decimal)Config.General.DisabledAudioVolume;

            BindingToggleA.Text = Config.Binding.ToggleA.ToString();
            BindingToggleB.Text = Config.Binding.ToggleB.ToString();
            BindingUp.Text = Config.Binding.Up.ToString();
            BindingDown.Text = Config.Binding.Down.ToString();
            BindingLeft.Text = Config.Binding.Left.ToString();
            BindingRight.Text = Config.Binding.Right.ToString();
            BindingA.Text = Config.Binding.A.ToString();
            BindingB.Text = Config.Binding.B.ToString();
            BindingX.Text = Config.Binding.X.ToString();
            BindingY.Text = Config.Binding.Y.ToString();
            BindingL1.Text = Config.Binding.L1.ToString();
            BindingL2.Text = Config.Binding.L2.ToString();
            BindingR1.Text = Config.Binding.R1.ToString();
            BindingR2.Text = Config.Binding.R2.ToString();
            BindingStart.Text = Config.Binding.Start.ToString();
            BindingBack.Text = Config.Binding.Back.ToString();
        }

        private void ToggleAPassthrough_CheckedChanged(object sender, EventArgs e) {
            Config.General.ToggleAPassthrough = ToggleAPassthrough.Checked;
            Config.Save();
        }
        private void ToggleBPassthrough_CheckedChanged(object sender, EventArgs e) {
            Config.General.ToggleBPassthrough = ToggleBPassthrough.Checked;
            Config.Save();
        }
        private void ToggleAAudio_CheckedChanged(object sender, EventArgs e) {
            Config.General.ToggleAAudio = ToggleAAudio.Checked;
            Config.Save();
        }
        private void ToggleBAudio_CheckedChanged(object sender, EventArgs e) {
            Config.General.ToggleBAudio = ToggleBAudio.Checked;
            Config.Save();
        }
        private void ClientTitle_KeyUp(object sender, KeyEventArgs e) {
            Config.General.ClientTitle = ClientTitle.Text;
            Config.Save();
        }
        private void EnabledVolume_ValueChanged(object sender, EventArgs e) {
            Config.General.EnabledAudioVolume = (double)EnabledVolume.Value;
            Config.Save();
        }
        private void DisabledVolume_ValueChanged(object sender, EventArgs e) {
            Config.General.DisabledAudioVolume = (double)DisabledVolume.Value;
            Config.Save();
        }

        private void UpdateBinding(Buttons button) {
            if(InputHook.Updating) {
                Binding binding = InputHook.Bindings.Find(x => x.Updating && x.Button != button);
                if(binding != null) {
                    binding.Updating = false;
                    InitializeConfig();
                }
            }

            InputHook.Updating = true;
            InputHook.Bindings.Find(x => x.Button == button).Updating = true;
        }

        private void BindingToggleA_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.ToggleA);
            BindingToggleA.Text = "";
        }
        private void BindingToggleB_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.ToggleB);
            BindingToggleB.Text = "";
        }
        private void BindingUp_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.Up);
            BindingUp.Text = "";
        }
        private void BindingDown_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.Down);
            BindingDown.Text = "";
        }
        private void BindingLeft_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.Left);
            BindingLeft.Text = "";
        }
        private void BindingRight_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.Right);
            BindingRight.Text = "";
        }
        private void BindingA_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.A);
            BindingA.Text = "";
        }
        private void BindingB_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.B);
            BindingB.Text = "";
        }
        private void BindingX_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.X);
            BindingX.Text = "";
        }
        private void BindingY_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.Y);
            BindingY.Text = "";
        }
        private void BindingL1_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.L1);
            BindingL1.Text = "";
        }
        private void BindingL2_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.L2);
            BindingL2.Text = "";
        }
        private void BindingR1_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.R1);
            BindingR1.Text = "";
        }
        private void BindingR2_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.R2);
            BindingR2.Text = "";
        }
        private void BindingStart_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.Start);
            BindingStart.Text = "";
        }
        private void BindingBack_Click(object sender, EventArgs e) {
            UpdateBinding(Buttons.Back);
            BindingBack.Text = "";
        }
    }
}
