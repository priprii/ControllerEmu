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
        private short xPos = 0;
        private short yPos = 0;

        public MainWindow() {
            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            Config.Load();
            InitializeConfigMenu();

            InputHook = new InputHook(Config.General.ToggleKey);
            InputHook.ToggleKeyUpdated += InputHook_ToggleKeyUpdated;
            InputHook.StateChanged += InputHook_StateChanged;
            InputHook.KeyPress += InputHook_KeyPress;

            if(Config.General.ConnectOnStart) {
                ToggleController(true);
            }
        }

        private void InputHook_ToggleKeyUpdated(object sender, KeyHookEventArgs e) {
            Config.General.ToggleKey = (int)e.Key;
            Config.Save();
            Audio.Play(Config.Audio.EnabledAudioFile, Config.Audio.EnabledAudioVolume);
            InitializeConfigMenu();
        }

        private void InputHook_StateChanged(object sender, EventArgs e) {
            if(InputHook.Active && Config.Audio.EnabledAudioNotification && Config.Audio.EnabledAudioVolume > 0) {
                Audio.Play(Config.Audio.EnabledAudioFile, Config.Audio.EnabledAudioVolume);
            } else if(!InputHook.Active && Config.Audio.DisabledAudioNotification && Config.Audio.DisabledAudioVolume > 0) {
                Audio.Play(Config.Audio.DisabledAudioFile, Config.Audio.DisabledAudioVolume);
            }
        }

        private void InputHook_KeyPress(object sender, KeyHookEventArgs e) {
            switch(e.Key) {
                case Keys.W:
                    if(e.KeyState == KeyState.KeyUp && yPos == 32767) {
                        yPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    } else if(e.KeyState == KeyState.KeyDown) {
                        yPos = 32767;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    }
                    break;
                case Keys.A:
                    if(e.KeyState == KeyState.KeyUp && xPos == -32768) {
                        xPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    } else if(e.KeyState == KeyState.KeyDown) {
                        xPos = -32768;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    }
                    break;
                case Keys.S:
                    if(e.KeyState == KeyState.KeyUp && yPos == -32768) {
                        yPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    } else if(e.KeyState == KeyState.KeyDown) {
                        yPos = -32768;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbY, yPos);
                    }
                    break;
                case Keys.D:
                    if(e.KeyState == KeyState.KeyUp && xPos == 32767) {
                        xPos = 0;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    } else if(e.KeyState == KeyState.KeyDown) {
                        xPos = 32767;
                        Controller.SetAxisValue(Xbox360Axis.LeftThumbX, xPos);
                    }
                    break;
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
            if(Controller != null) { Controller.Disconnect(); Controller = null; }
            if(Client != null) { Client.Dispose(); Client = null; }
            InputHook.Unhook();
            Audio.StopMediaManager();
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            if(WindowState == FormWindowState.Minimized) { Hide(); }
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

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                TrayCMenu.Show(Cursor.Position);
            }
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
            InitializeConfigMenu();
        }
        private void TrayCMenuSetToggleKey_Click(object sender, EventArgs e) {
            InputHook.UpdatingToggleKey = true;
        }
        private void TrayCMenuConnectOnStart_Click(object sender, EventArgs e) {
            Config.General.ConnectOnStart = !Config.General.ConnectOnStart;
            TrayCMenuConnectOnStart.Checked = Config.General.ConnectOnStart;
            Config.Save();
        }
        private void TrayCMenuPlayEnabledAudio_Click(object sender, EventArgs e) {
            Config.Audio.EnabledAudioNotification = !Config.Audio.EnabledAudioNotification;
            TrayCMenuPlayEnabledAudio.Checked = Config.Audio.EnabledAudioNotification;
            Config.Save();
        }
        private void TrayCMenuPlayDisabledAudio_Click(object sender, EventArgs e) {
            Config.Audio.DisabledAudioNotification = !Config.Audio.DisabledAudioNotification;
            TrayCMenuPlayDisabledAudio.Checked = Config.Audio.DisabledAudioNotification;
            Config.Save();
        }

        private void InitializeConfigMenu() {
            TrayCMenuSetToggleKey.Text = $"Set Toggle Key ({(Keys)Config.General.ToggleKey})";
            TrayCMenuConnectOnStart.Checked = Config.General.ConnectOnStart;
            TrayCMenuPlayEnabledAudio.Checked = Config.Audio.EnabledAudioNotification;
            TrayCMenuPlayDisabledAudio.Checked = Config.Audio.DisabledAudioNotification;
        }
    }
}
