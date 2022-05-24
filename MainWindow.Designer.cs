namespace ControllerEmu {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayCMenu = new Pri.Controls.PriContextMenuStrip(this.components);
            this.TrayCMenuToggleConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuSetToggleKey = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuConnectOnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuEnableOnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuPlayEnabledAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuPlayDisabledAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuReloadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayCMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "ControllerEmu";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // TrayCMenu
            // 
            this.TrayCMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.TrayCMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TrayCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayCMenuToggleConnect,
            this.TrayCMenuConfig,
            this.TrayCMenuReloadConfig,
            this.TrayCMenuExit});
            this.TrayCMenu.Name = "TrayCMenu";
            this.TrayCMenu.ShowImageMargin = false;
            this.TrayCMenu.ShowItemToolTips = false;
            this.TrayCMenu.Size = new System.Drawing.Size(156, 114);
            // 
            // TrayCMenuToggleConnect
            // 
            this.TrayCMenuToggleConnect.Name = "TrayCMenuToggleConnect";
            this.TrayCMenuToggleConnect.Size = new System.Drawing.Size(155, 22);
            this.TrayCMenuToggleConnect.Text = "Connect Controller";
            this.TrayCMenuToggleConnect.ToolTipText = "Toggle whether the emulated controller is connected.";
            this.TrayCMenuToggleConnect.Click += new System.EventHandler(this.TrayCMenuToggleConnect_Click);
            // 
            // TrayCMenuConfig
            // 
            this.TrayCMenuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayCMenuSetToggleKey,
            this.TrayCMenuConnectOnStart,
            this.TrayCMenuEnableOnStart,
            this.TrayCMenuPlayEnabledAudio,
            this.TrayCMenuPlayDisabledAudio});
            this.TrayCMenuConfig.Name = "TrayCMenuConfig";
            this.TrayCMenuConfig.Size = new System.Drawing.Size(155, 22);
            this.TrayCMenuConfig.Text = "Config";
            // 
            // TrayCMenuSetToggleKey
            // 
            this.TrayCMenuSetToggleKey.Name = "TrayCMenuSetToggleKey";
            this.TrayCMenuSetToggleKey.Size = new System.Drawing.Size(180, 22);
            this.TrayCMenuSetToggleKey.Text = "Set Toggle Key";
            this.TrayCMenuSetToggleKey.ToolTipText = "The key pressed after clicking this will be the key used for toggling controller " +
    "emulation.";
            this.TrayCMenuSetToggleKey.Click += new System.EventHandler(this.TrayCMenuSetToggleKey_Click);
            // 
            // TrayCMenuConnectOnStart
            // 
            this.TrayCMenuConnectOnStart.Name = "TrayCMenuConnectOnStart";
            this.TrayCMenuConnectOnStart.Size = new System.Drawing.Size(180, 22);
            this.TrayCMenuConnectOnStart.Text = "Connect on Start";
            this.TrayCMenuConnectOnStart.ToolTipText = "Connect the emulated controller when ControllerEmu is started.\r\nOtherwise, the \'C" +
    "onnect Controller\' option in this menu needs to be manually pressed.";
            this.TrayCMenuConnectOnStart.Click += new System.EventHandler(this.TrayCMenuConnectOnStart_Click);
            // 
            // TrayCMenuEnableOnStart
            // 
            this.TrayCMenuEnableOnStart.Name = "TrayCMenuEnableOnStart";
            this.TrayCMenuEnableOnStart.Size = new System.Drawing.Size(180, 22);
            this.TrayCMenuEnableOnStart.Text = "Enable on Start";
            this.TrayCMenuEnableOnStart.ToolTipText = resources.GetString("TrayCMenuEnableOnStart.ToolTipText");
            this.TrayCMenuEnableOnStart.Click += new System.EventHandler(this.TrayCMenuEnableOnStart_Click);
            // 
            // TrayCMenuPlayEnabledAudio
            // 
            this.TrayCMenuPlayEnabledAudio.Name = "TrayCMenuPlayEnabledAudio";
            this.TrayCMenuPlayEnabledAudio.Size = new System.Drawing.Size(180, 22);
            this.TrayCMenuPlayEnabledAudio.Text = "Play Enabled Audio";
            this.TrayCMenuPlayEnabledAudio.Click += new System.EventHandler(this.TrayCMenuPlayEnabledAudio_Click);
            // 
            // TrayCMenuPlayDisabledAudio
            // 
            this.TrayCMenuPlayDisabledAudio.Name = "TrayCMenuPlayDisabledAudio";
            this.TrayCMenuPlayDisabledAudio.Size = new System.Drawing.Size(180, 22);
            this.TrayCMenuPlayDisabledAudio.Text = "Play Disabled Audio";
            this.TrayCMenuPlayDisabledAudio.Click += new System.EventHandler(this.TrayCMenuPlayDisabledAudio_Click);
            // 
            // TrayCMenuReloadConfig
            // 
            this.TrayCMenuReloadConfig.Name = "TrayCMenuReloadConfig";
            this.TrayCMenuReloadConfig.Size = new System.Drawing.Size(155, 22);
            this.TrayCMenuReloadConfig.Text = "Reload Config";
            this.TrayCMenuReloadConfig.Click += new System.EventHandler(this.TrayCMenuReloadConfig_Click);
            // 
            // TrayCMenuExit
            // 
            this.TrayCMenuExit.Name = "TrayCMenuExit";
            this.TrayCMenuExit.Size = new System.Drawing.Size(155, 22);
            this.TrayCMenuExit.Text = "Exit";
            this.TrayCMenuExit.Click += new System.EventHandler(this.TrayCMenuExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(113, 65);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.Text = "ControllerEmu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.TrayCMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private Pri.Controls.PriContextMenuStrip TrayCMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuToggleConnect;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuExit;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuConfig;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuReloadConfig;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuSetToggleKey;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuPlayEnabledAudio;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuPlayDisabledAudio;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuConnectOnStart;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuEnableOnStart;
    }
}

