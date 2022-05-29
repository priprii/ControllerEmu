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
            this.TrayCMenuReloadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.priLabel1 = new Pri.Controls.PriLabel();
            this.priLabel2 = new Pri.Controls.PriLabel();
            this.priLabel3 = new Pri.Controls.PriLabel();
            this.priLabel4 = new Pri.Controls.PriLabel();
            this.priLabel5 = new Pri.Controls.PriLabel();
            this.priLabel6 = new Pri.Controls.PriLabel();
            this.priLabel7 = new Pri.Controls.PriLabel();
            this.priLabel8 = new Pri.Controls.PriLabel();
            this.priLabel9 = new Pri.Controls.PriLabel();
            this.priLabel10 = new Pri.Controls.PriLabel();
            this.priLabel11 = new Pri.Controls.PriLabel();
            this.priLabel12 = new Pri.Controls.PriLabel();
            this.BindingUp = new Pri.Controls.PriTextBox();
            this.BindingDown = new Pri.Controls.PriTextBox();
            this.BindingLeft = new Pri.Controls.PriTextBox();
            this.BindingRight = new Pri.Controls.PriTextBox();
            this.BindingY = new Pri.Controls.PriTextBox();
            this.BindingX = new Pri.Controls.PriTextBox();
            this.BindingB = new Pri.Controls.PriTextBox();
            this.BindingA = new Pri.Controls.PriTextBox();
            this.BindingR2 = new Pri.Controls.PriTextBox();
            this.BindingR1 = new Pri.Controls.PriTextBox();
            this.BindingL2 = new Pri.Controls.PriTextBox();
            this.BindingL1 = new Pri.Controls.PriTextBox();
            this.BindingBack = new Pri.Controls.PriTextBox();
            this.BindingStart = new Pri.Controls.PriTextBox();
            this.priLabel13 = new Pri.Controls.PriLabel();
            this.priLabel14 = new Pri.Controls.PriLabel();
            this.BindingToggleA = new Pri.Controls.PriTextBox();
            this.priLabel15 = new Pri.Controls.PriLabel();
            this.ClientTitle = new Pri.Controls.PriTextBox();
            this.EnabledVolume = new Pri.Controls.PriTrackBar();
            this.DisabledVolume = new Pri.Controls.PriTrackBar();
            this.ToggleAPassthrough = new Pri.Controls.PriCheckBox();
            this.ToggleAAudio = new Pri.Controls.PriCheckBox();
            this.ToggleBAudio = new Pri.Controls.PriCheckBox();
            this.ToggleBPassthrough = new Pri.Controls.PriCheckBox();
            this.BindingToggleB = new Pri.Controls.PriTextBox();
            this.priLabel16 = new Pri.Controls.PriLabel();
            this.priLabel17 = new Pri.Controls.PriLabel();
            this.priLabel18 = new Pri.Controls.PriLabel();
            this.BindingSkills = new Pri.Controls.PriComboBox();
            this.BindingSkillsUpdate = new Pri.Controls.PriButton();
            this.TrayCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayCMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "ControllerEmu";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // TrayCMenu
            // 
            this.TrayCMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.TrayCMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TrayCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayCMenuToggleConnect,
            this.TrayCMenuReloadConfig,
            this.TrayCMenuExit});
            this.TrayCMenu.Name = "TrayCMenu";
            this.TrayCMenu.ShowImageMargin = false;
            this.TrayCMenu.ShowItemToolTips = false;
            this.TrayCMenu.Size = new System.Drawing.Size(151, 70);
            // 
            // TrayCMenuToggleConnect
            // 
            this.TrayCMenuToggleConnect.Name = "TrayCMenuToggleConnect";
            this.TrayCMenuToggleConnect.Size = new System.Drawing.Size(150, 22);
            this.TrayCMenuToggleConnect.Text = "Connect Controller";
            this.TrayCMenuToggleConnect.ToolTipText = "Toggle whether the emulated controller is connected.";
            this.TrayCMenuToggleConnect.Click += new System.EventHandler(this.TrayCMenuToggleConnect_Click);
            // 
            // TrayCMenuReloadConfig
            // 
            this.TrayCMenuReloadConfig.Name = "TrayCMenuReloadConfig";
            this.TrayCMenuReloadConfig.Size = new System.Drawing.Size(150, 22);
            this.TrayCMenuReloadConfig.Text = "Reload Config";
            this.TrayCMenuReloadConfig.Click += new System.EventHandler(this.TrayCMenuReloadConfig_Click);
            // 
            // TrayCMenuExit
            // 
            this.TrayCMenuExit.Name = "TrayCMenuExit";
            this.TrayCMenuExit.Size = new System.Drawing.Size(150, 22);
            this.TrayCMenuExit.Text = "Exit";
            this.TrayCMenuExit.Click += new System.EventHandler(this.TrayCMenuExit_Click);
            // 
            // priLabel1
            // 
            this.priLabel1.Location = new System.Drawing.Point(5, 153);
            this.priLabel1.Name = "priLabel1";
            this.priLabel1.Size = new System.Drawing.Size(57, 23);
            this.priLabel1.TabIndex = 1;
            this.priLabel1.Text = "Up";
            this.priLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel2
            // 
            this.priLabel2.Location = new System.Drawing.Point(5, 176);
            this.priLabel2.Name = "priLabel2";
            this.priLabel2.Size = new System.Drawing.Size(57, 23);
            this.priLabel2.TabIndex = 2;
            this.priLabel2.Text = "Down";
            this.priLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel3
            // 
            this.priLabel3.Location = new System.Drawing.Point(5, 199);
            this.priLabel3.Name = "priLabel3";
            this.priLabel3.Size = new System.Drawing.Size(57, 23);
            this.priLabel3.TabIndex = 3;
            this.priLabel3.Text = "Left";
            this.priLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel4
            // 
            this.priLabel4.Location = new System.Drawing.Point(5, 222);
            this.priLabel4.Name = "priLabel4";
            this.priLabel4.Size = new System.Drawing.Size(57, 23);
            this.priLabel4.TabIndex = 4;
            this.priLabel4.Text = "Right";
            this.priLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel5
            // 
            this.priLabel5.Location = new System.Drawing.Point(163, 153);
            this.priLabel5.Name = "priLabel5";
            this.priLabel5.Size = new System.Drawing.Size(57, 23);
            this.priLabel5.TabIndex = 5;
            this.priLabel5.Text = "A";
            this.priLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel6
            // 
            this.priLabel6.Location = new System.Drawing.Point(163, 176);
            this.priLabel6.Name = "priLabel6";
            this.priLabel6.Size = new System.Drawing.Size(57, 23);
            this.priLabel6.TabIndex = 6;
            this.priLabel6.Text = "B";
            this.priLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel7
            // 
            this.priLabel7.Location = new System.Drawing.Point(163, 199);
            this.priLabel7.Name = "priLabel7";
            this.priLabel7.Size = new System.Drawing.Size(57, 23);
            this.priLabel7.TabIndex = 7;
            this.priLabel7.Text = "X";
            this.priLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel8
            // 
            this.priLabel8.Location = new System.Drawing.Point(163, 222);
            this.priLabel8.Name = "priLabel8";
            this.priLabel8.Size = new System.Drawing.Size(57, 23);
            this.priLabel8.TabIndex = 8;
            this.priLabel8.Text = "Y";
            this.priLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel9
            // 
            this.priLabel9.Location = new System.Drawing.Point(321, 153);
            this.priLabel9.Name = "priLabel9";
            this.priLabel9.Size = new System.Drawing.Size(57, 23);
            this.priLabel9.TabIndex = 9;
            this.priLabel9.Text = "L1";
            this.priLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel10
            // 
            this.priLabel10.Location = new System.Drawing.Point(321, 176);
            this.priLabel10.Name = "priLabel10";
            this.priLabel10.Size = new System.Drawing.Size(57, 23);
            this.priLabel10.TabIndex = 10;
            this.priLabel10.Text = "L2";
            this.priLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel11
            // 
            this.priLabel11.Location = new System.Drawing.Point(321, 199);
            this.priLabel11.Name = "priLabel11";
            this.priLabel11.Size = new System.Drawing.Size(57, 23);
            this.priLabel11.TabIndex = 11;
            this.priLabel11.Text = "R1";
            this.priLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel12
            // 
            this.priLabel12.Location = new System.Drawing.Point(321, 222);
            this.priLabel12.Name = "priLabel12";
            this.priLabel12.Size = new System.Drawing.Size(57, 23);
            this.priLabel12.TabIndex = 12;
            this.priLabel12.Text = "R2";
            this.priLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BindingUp
            // 
            // 
            // 
            // 
            this.BindingUp.CustomButton.Image = null;
            this.BindingUp.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingUp.CustomButton.Name = "";
            this.BindingUp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingUp.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingUp.CustomButton.TabIndex = 4;
            this.BindingUp.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingUp.CustomButton.UseSelectable = true;
            this.BindingUp.CustomButton.Visible = false;
            this.BindingUp.Lines = new string[] {
        "None"};
            this.BindingUp.Location = new System.Drawing.Point(78, 153);
            this.BindingUp.MaxLength = 32767;
            this.BindingUp.Name = "BindingUp";
            this.BindingUp.PasswordChar = '\0';
            this.BindingUp.ReadOnly = true;
            this.BindingUp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingUp.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingUp.SelectedText = "";
            this.BindingUp.SelectionLength = 0;
            this.BindingUp.SelectionStart = 0;
            this.BindingUp.ShortcutsEnabled = false;
            this.BindingUp.Size = new System.Drawing.Size(63, 23);
            this.BindingUp.TabIndex = 13;
            this.BindingUp.TabStop = false;
            this.BindingUp.Text = "None";
            this.BindingUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingUp.UseSelectable = true;
            this.BindingUp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingUp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingUp.Click += new System.EventHandler(this.BindingUp_Click);
            // 
            // BindingDown
            // 
            // 
            // 
            // 
            this.BindingDown.CustomButton.Image = null;
            this.BindingDown.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingDown.CustomButton.Name = "";
            this.BindingDown.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingDown.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingDown.CustomButton.TabIndex = 4;
            this.BindingDown.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingDown.CustomButton.UseSelectable = true;
            this.BindingDown.CustomButton.Visible = false;
            this.BindingDown.Lines = new string[] {
        "None"};
            this.BindingDown.Location = new System.Drawing.Point(78, 176);
            this.BindingDown.MaxLength = 32767;
            this.BindingDown.Name = "BindingDown";
            this.BindingDown.PasswordChar = '\0';
            this.BindingDown.ReadOnly = true;
            this.BindingDown.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingDown.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingDown.SelectedText = "";
            this.BindingDown.SelectionLength = 0;
            this.BindingDown.SelectionStart = 0;
            this.BindingDown.ShortcutsEnabled = false;
            this.BindingDown.Size = new System.Drawing.Size(63, 23);
            this.BindingDown.TabIndex = 14;
            this.BindingDown.TabStop = false;
            this.BindingDown.Text = "None";
            this.BindingDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingDown.UseSelectable = true;
            this.BindingDown.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingDown.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingDown.Click += new System.EventHandler(this.BindingDown_Click);
            // 
            // BindingLeft
            // 
            // 
            // 
            // 
            this.BindingLeft.CustomButton.Image = null;
            this.BindingLeft.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingLeft.CustomButton.Name = "";
            this.BindingLeft.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingLeft.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingLeft.CustomButton.TabIndex = 4;
            this.BindingLeft.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingLeft.CustomButton.UseSelectable = true;
            this.BindingLeft.CustomButton.Visible = false;
            this.BindingLeft.Lines = new string[] {
        "None"};
            this.BindingLeft.Location = new System.Drawing.Point(78, 199);
            this.BindingLeft.MaxLength = 32767;
            this.BindingLeft.Name = "BindingLeft";
            this.BindingLeft.PasswordChar = '\0';
            this.BindingLeft.ReadOnly = true;
            this.BindingLeft.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingLeft.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingLeft.SelectedText = "";
            this.BindingLeft.SelectionLength = 0;
            this.BindingLeft.SelectionStart = 0;
            this.BindingLeft.ShortcutsEnabled = false;
            this.BindingLeft.Size = new System.Drawing.Size(63, 23);
            this.BindingLeft.TabIndex = 15;
            this.BindingLeft.TabStop = false;
            this.BindingLeft.Text = "None";
            this.BindingLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingLeft.UseSelectable = true;
            this.BindingLeft.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingLeft.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingLeft.Click += new System.EventHandler(this.BindingLeft_Click);
            // 
            // BindingRight
            // 
            // 
            // 
            // 
            this.BindingRight.CustomButton.Image = null;
            this.BindingRight.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingRight.CustomButton.Name = "";
            this.BindingRight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingRight.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingRight.CustomButton.TabIndex = 4;
            this.BindingRight.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingRight.CustomButton.UseSelectable = true;
            this.BindingRight.CustomButton.Visible = false;
            this.BindingRight.Lines = new string[] {
        "None"};
            this.BindingRight.Location = new System.Drawing.Point(78, 222);
            this.BindingRight.MaxLength = 32767;
            this.BindingRight.Name = "BindingRight";
            this.BindingRight.PasswordChar = '\0';
            this.BindingRight.ReadOnly = true;
            this.BindingRight.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingRight.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingRight.SelectedText = "";
            this.BindingRight.SelectionLength = 0;
            this.BindingRight.SelectionStart = 0;
            this.BindingRight.ShortcutsEnabled = false;
            this.BindingRight.Size = new System.Drawing.Size(63, 23);
            this.BindingRight.TabIndex = 16;
            this.BindingRight.TabStop = false;
            this.BindingRight.Text = "None";
            this.BindingRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingRight.UseSelectable = true;
            this.BindingRight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingRight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingRight.Click += new System.EventHandler(this.BindingRight_Click);
            // 
            // BindingY
            // 
            // 
            // 
            // 
            this.BindingY.CustomButton.Image = null;
            this.BindingY.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingY.CustomButton.Name = "";
            this.BindingY.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingY.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingY.CustomButton.TabIndex = 4;
            this.BindingY.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingY.CustomButton.UseSelectable = true;
            this.BindingY.CustomButton.Visible = false;
            this.BindingY.Lines = new string[] {
        "None"};
            this.BindingY.Location = new System.Drawing.Point(236, 222);
            this.BindingY.MaxLength = 32767;
            this.BindingY.Name = "BindingY";
            this.BindingY.PasswordChar = '\0';
            this.BindingY.ReadOnly = true;
            this.BindingY.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingY.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingY.SelectedText = "";
            this.BindingY.SelectionLength = 0;
            this.BindingY.SelectionStart = 0;
            this.BindingY.ShortcutsEnabled = false;
            this.BindingY.Size = new System.Drawing.Size(63, 23);
            this.BindingY.TabIndex = 20;
            this.BindingY.TabStop = false;
            this.BindingY.Text = "None";
            this.BindingY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingY.UseSelectable = true;
            this.BindingY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingY.Click += new System.EventHandler(this.BindingY_Click);
            // 
            // BindingX
            // 
            // 
            // 
            // 
            this.BindingX.CustomButton.Image = null;
            this.BindingX.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingX.CustomButton.Name = "";
            this.BindingX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingX.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingX.CustomButton.TabIndex = 4;
            this.BindingX.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingX.CustomButton.UseSelectable = true;
            this.BindingX.CustomButton.Visible = false;
            this.BindingX.Lines = new string[] {
        "None"};
            this.BindingX.Location = new System.Drawing.Point(236, 199);
            this.BindingX.MaxLength = 32767;
            this.BindingX.Name = "BindingX";
            this.BindingX.PasswordChar = '\0';
            this.BindingX.ReadOnly = true;
            this.BindingX.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingX.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingX.SelectedText = "";
            this.BindingX.SelectionLength = 0;
            this.BindingX.SelectionStart = 0;
            this.BindingX.ShortcutsEnabled = false;
            this.BindingX.Size = new System.Drawing.Size(63, 23);
            this.BindingX.TabIndex = 19;
            this.BindingX.TabStop = false;
            this.BindingX.Text = "None";
            this.BindingX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingX.UseSelectable = true;
            this.BindingX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingX.Click += new System.EventHandler(this.BindingX_Click);
            // 
            // BindingB
            // 
            // 
            // 
            // 
            this.BindingB.CustomButton.Image = null;
            this.BindingB.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingB.CustomButton.Name = "";
            this.BindingB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingB.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingB.CustomButton.TabIndex = 4;
            this.BindingB.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingB.CustomButton.UseSelectable = true;
            this.BindingB.CustomButton.Visible = false;
            this.BindingB.Lines = new string[] {
        "None"};
            this.BindingB.Location = new System.Drawing.Point(236, 176);
            this.BindingB.MaxLength = 32767;
            this.BindingB.Name = "BindingB";
            this.BindingB.PasswordChar = '\0';
            this.BindingB.ReadOnly = true;
            this.BindingB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingB.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingB.SelectedText = "";
            this.BindingB.SelectionLength = 0;
            this.BindingB.SelectionStart = 0;
            this.BindingB.ShortcutsEnabled = false;
            this.BindingB.Size = new System.Drawing.Size(63, 23);
            this.BindingB.TabIndex = 18;
            this.BindingB.TabStop = false;
            this.BindingB.Text = "None";
            this.BindingB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingB.UseSelectable = true;
            this.BindingB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingB.Click += new System.EventHandler(this.BindingB_Click);
            // 
            // BindingA
            // 
            // 
            // 
            // 
            this.BindingA.CustomButton.Image = null;
            this.BindingA.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingA.CustomButton.Name = "";
            this.BindingA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingA.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingA.CustomButton.TabIndex = 4;
            this.BindingA.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingA.CustomButton.UseSelectable = true;
            this.BindingA.CustomButton.Visible = false;
            this.BindingA.Lines = new string[] {
        "None"};
            this.BindingA.Location = new System.Drawing.Point(236, 153);
            this.BindingA.MaxLength = 32767;
            this.BindingA.Name = "BindingA";
            this.BindingA.PasswordChar = '\0';
            this.BindingA.ReadOnly = true;
            this.BindingA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingA.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingA.SelectedText = "";
            this.BindingA.SelectionLength = 0;
            this.BindingA.SelectionStart = 0;
            this.BindingA.ShortcutsEnabled = false;
            this.BindingA.Size = new System.Drawing.Size(63, 23);
            this.BindingA.TabIndex = 17;
            this.BindingA.TabStop = false;
            this.BindingA.Text = "None";
            this.BindingA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingA.UseSelectable = true;
            this.BindingA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingA.Click += new System.EventHandler(this.BindingA_Click);
            // 
            // BindingR2
            // 
            // 
            // 
            // 
            this.BindingR2.CustomButton.Image = null;
            this.BindingR2.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingR2.CustomButton.Name = "";
            this.BindingR2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingR2.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingR2.CustomButton.TabIndex = 4;
            this.BindingR2.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingR2.CustomButton.UseSelectable = true;
            this.BindingR2.CustomButton.Visible = false;
            this.BindingR2.Lines = new string[] {
        "None"};
            this.BindingR2.Location = new System.Drawing.Point(394, 222);
            this.BindingR2.MaxLength = 32767;
            this.BindingR2.Name = "BindingR2";
            this.BindingR2.PasswordChar = '\0';
            this.BindingR2.ReadOnly = true;
            this.BindingR2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingR2.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingR2.SelectedText = "";
            this.BindingR2.SelectionLength = 0;
            this.BindingR2.SelectionStart = 0;
            this.BindingR2.ShortcutsEnabled = false;
            this.BindingR2.Size = new System.Drawing.Size(63, 23);
            this.BindingR2.TabIndex = 24;
            this.BindingR2.TabStop = false;
            this.BindingR2.Text = "None";
            this.BindingR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingR2.UseSelectable = true;
            this.BindingR2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingR2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingR2.Click += new System.EventHandler(this.BindingR2_Click);
            // 
            // BindingR1
            // 
            // 
            // 
            // 
            this.BindingR1.CustomButton.Image = null;
            this.BindingR1.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingR1.CustomButton.Name = "";
            this.BindingR1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingR1.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingR1.CustomButton.TabIndex = 4;
            this.BindingR1.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingR1.CustomButton.UseSelectable = true;
            this.BindingR1.CustomButton.Visible = false;
            this.BindingR1.Lines = new string[] {
        "None"};
            this.BindingR1.Location = new System.Drawing.Point(394, 199);
            this.BindingR1.MaxLength = 32767;
            this.BindingR1.Name = "BindingR1";
            this.BindingR1.PasswordChar = '\0';
            this.BindingR1.ReadOnly = true;
            this.BindingR1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingR1.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingR1.SelectedText = "";
            this.BindingR1.SelectionLength = 0;
            this.BindingR1.SelectionStart = 0;
            this.BindingR1.ShortcutsEnabled = false;
            this.BindingR1.Size = new System.Drawing.Size(63, 23);
            this.BindingR1.TabIndex = 23;
            this.BindingR1.TabStop = false;
            this.BindingR1.Text = "None";
            this.BindingR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingR1.UseSelectable = true;
            this.BindingR1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingR1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingR1.Click += new System.EventHandler(this.BindingR1_Click);
            // 
            // BindingL2
            // 
            // 
            // 
            // 
            this.BindingL2.CustomButton.Image = null;
            this.BindingL2.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingL2.CustomButton.Name = "";
            this.BindingL2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingL2.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingL2.CustomButton.TabIndex = 4;
            this.BindingL2.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingL2.CustomButton.UseSelectable = true;
            this.BindingL2.CustomButton.Visible = false;
            this.BindingL2.Lines = new string[] {
        "None"};
            this.BindingL2.Location = new System.Drawing.Point(394, 176);
            this.BindingL2.MaxLength = 32767;
            this.BindingL2.Name = "BindingL2";
            this.BindingL2.PasswordChar = '\0';
            this.BindingL2.ReadOnly = true;
            this.BindingL2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingL2.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingL2.SelectedText = "";
            this.BindingL2.SelectionLength = 0;
            this.BindingL2.SelectionStart = 0;
            this.BindingL2.ShortcutsEnabled = false;
            this.BindingL2.Size = new System.Drawing.Size(63, 23);
            this.BindingL2.TabIndex = 22;
            this.BindingL2.TabStop = false;
            this.BindingL2.Text = "None";
            this.BindingL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingL2.UseSelectable = true;
            this.BindingL2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingL2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingL2.Click += new System.EventHandler(this.BindingL2_Click);
            // 
            // BindingL1
            // 
            // 
            // 
            // 
            this.BindingL1.CustomButton.Image = null;
            this.BindingL1.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingL1.CustomButton.Name = "";
            this.BindingL1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingL1.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingL1.CustomButton.TabIndex = 4;
            this.BindingL1.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingL1.CustomButton.UseSelectable = true;
            this.BindingL1.CustomButton.Visible = false;
            this.BindingL1.Lines = new string[] {
        "None"};
            this.BindingL1.Location = new System.Drawing.Point(394, 153);
            this.BindingL1.MaxLength = 32767;
            this.BindingL1.Name = "BindingL1";
            this.BindingL1.PasswordChar = '\0';
            this.BindingL1.ReadOnly = true;
            this.BindingL1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingL1.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingL1.SelectedText = "";
            this.BindingL1.SelectionLength = 0;
            this.BindingL1.SelectionStart = 0;
            this.BindingL1.ShortcutsEnabled = false;
            this.BindingL1.Size = new System.Drawing.Size(63, 23);
            this.BindingL1.TabIndex = 21;
            this.BindingL1.TabStop = false;
            this.BindingL1.Text = "None";
            this.BindingL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingL1.UseSelectable = true;
            this.BindingL1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingL1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingL1.Click += new System.EventHandler(this.BindingL1_Click);
            // 
            // BindingBack
            // 
            // 
            // 
            // 
            this.BindingBack.CustomButton.Image = null;
            this.BindingBack.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingBack.CustomButton.Name = "";
            this.BindingBack.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingBack.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingBack.CustomButton.TabIndex = 4;
            this.BindingBack.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingBack.CustomButton.UseSelectable = true;
            this.BindingBack.CustomButton.Visible = false;
            this.BindingBack.Lines = new string[] {
        "None"};
            this.BindingBack.Location = new System.Drawing.Point(236, 251);
            this.BindingBack.MaxLength = 32767;
            this.BindingBack.Name = "BindingBack";
            this.BindingBack.PasswordChar = '\0';
            this.BindingBack.ReadOnly = true;
            this.BindingBack.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingBack.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingBack.SelectedText = "";
            this.BindingBack.SelectionLength = 0;
            this.BindingBack.SelectionStart = 0;
            this.BindingBack.ShortcutsEnabled = false;
            this.BindingBack.Size = new System.Drawing.Size(63, 23);
            this.BindingBack.TabIndex = 28;
            this.BindingBack.TabStop = false;
            this.BindingBack.Text = "None";
            this.BindingBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingBack.UseSelectable = true;
            this.BindingBack.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingBack.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingBack.Click += new System.EventHandler(this.BindingBack_Click);
            // 
            // BindingStart
            // 
            // 
            // 
            // 
            this.BindingStart.CustomButton.Image = null;
            this.BindingStart.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingStart.CustomButton.Name = "";
            this.BindingStart.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingStart.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingStart.CustomButton.TabIndex = 4;
            this.BindingStart.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingStart.CustomButton.UseSelectable = true;
            this.BindingStart.CustomButton.Visible = false;
            this.BindingStart.Lines = new string[] {
        "None"};
            this.BindingStart.Location = new System.Drawing.Point(394, 251);
            this.BindingStart.MaxLength = 32767;
            this.BindingStart.Name = "BindingStart";
            this.BindingStart.PasswordChar = '\0';
            this.BindingStart.ReadOnly = true;
            this.BindingStart.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingStart.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingStart.SelectedText = "";
            this.BindingStart.SelectionLength = 0;
            this.BindingStart.SelectionStart = 0;
            this.BindingStart.ShortcutsEnabled = false;
            this.BindingStart.Size = new System.Drawing.Size(63, 23);
            this.BindingStart.TabIndex = 27;
            this.BindingStart.TabStop = false;
            this.BindingStart.Text = "None";
            this.BindingStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingStart.UseSelectable = true;
            this.BindingStart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingStart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingStart.Click += new System.EventHandler(this.BindingStart_Click);
            // 
            // priLabel13
            // 
            this.priLabel13.Location = new System.Drawing.Point(321, 251);
            this.priLabel13.Name = "priLabel13";
            this.priLabel13.Size = new System.Drawing.Size(57, 23);
            this.priLabel13.TabIndex = 25;
            this.priLabel13.Text = "Start";
            this.priLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel14
            // 
            this.priLabel14.Location = new System.Drawing.Point(163, 251);
            this.priLabel14.Name = "priLabel14";
            this.priLabel14.Size = new System.Drawing.Size(57, 23);
            this.priLabel14.TabIndex = 26;
            this.priLabel14.Text = "Back";
            this.priLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BindingToggleA
            // 
            // 
            // 
            // 
            this.BindingToggleA.CustomButton.Image = null;
            this.BindingToggleA.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingToggleA.CustomButton.Name = "";
            this.BindingToggleA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingToggleA.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingToggleA.CustomButton.TabIndex = 4;
            this.BindingToggleA.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingToggleA.CustomButton.UseSelectable = true;
            this.BindingToggleA.CustomButton.Visible = false;
            this.BindingToggleA.Lines = new string[] {
        "None"};
            this.BindingToggleA.Location = new System.Drawing.Point(78, 38);
            this.BindingToggleA.MaxLength = 32767;
            this.BindingToggleA.Name = "BindingToggleA";
            this.BindingToggleA.PasswordChar = '\0';
            this.BindingToggleA.ReadOnly = true;
            this.BindingToggleA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingToggleA.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingToggleA.SelectedText = "";
            this.BindingToggleA.SelectionLength = 0;
            this.BindingToggleA.SelectionStart = 0;
            this.BindingToggleA.ShortcutsEnabled = false;
            this.BindingToggleA.Size = new System.Drawing.Size(63, 23);
            this.BindingToggleA.TabIndex = 30;
            this.BindingToggleA.TabStop = false;
            this.BindingToggleA.Text = "None";
            this.BindingToggleA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingToggleA.UseSelectable = true;
            this.BindingToggleA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingToggleA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingToggleA.Click += new System.EventHandler(this.BindingToggleA_Click);
            // 
            // priLabel15
            // 
            this.priLabel15.Location = new System.Drawing.Point(5, 38);
            this.priLabel15.Name = "priLabel15";
            this.priLabel15.Size = new System.Drawing.Size(67, 23);
            this.priLabel15.TabIndex = 29;
            this.priLabel15.Text = "Toggle A";
            this.priLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientTitle
            // 
            // 
            // 
            // 
            this.ClientTitle.CustomButton.Image = null;
            this.ClientTitle.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.ClientTitle.CustomButton.Name = "";
            this.ClientTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ClientTitle.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.ClientTitle.CustomButton.TabIndex = 4;
            this.ClientTitle.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.ClientTitle.CustomButton.UseSelectable = true;
            this.ClientTitle.CustomButton.Visible = false;
            this.ClientTitle.Lines = new string[0];
            this.ClientTitle.Location = new System.Drawing.Point(321, 43);
            this.ClientTitle.MaxLength = 32767;
            this.ClientTitle.Name = "ClientTitle";
            this.ClientTitle.PasswordChar = '\0';
            this.ClientTitle.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.ClientTitle.SelectedText = "";
            this.ClientTitle.SelectionLength = 0;
            this.ClientTitle.SelectionStart = 0;
            this.ClientTitle.ShortcutsEnabled = true;
            this.ClientTitle.Size = new System.Drawing.Size(136, 23);
            this.ClientTitle.TabIndex = 33;
            this.ClientTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientTitle.UseSelectable = true;
            this.ClientTitle.WaterMark = "Process Title";
            this.ClientTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ClientTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ClientTitle_KeyUp);
            // 
            // EnabledVolume
            // 
            this.EnabledVolume.BackColor = System.Drawing.Color.Transparent;
            this.EnabledVolume.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.EnabledVolume.Location = new System.Drawing.Point(321, 74);
            this.EnabledVolume.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EnabledVolume.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EnabledVolume.Name = "EnabledVolume";
            this.EnabledVolume.Size = new System.Drawing.Size(136, 23);
            this.EnabledVolume.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.EnabledVolume.TabIndex = 34;
            this.EnabledVolume.Text = "Enabled Volume: %s%";
            this.EnabledVolume.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.EnabledVolume.ValueDecimals = 2;
            this.EnabledVolume.ValueChanged += new System.EventHandler(this.EnabledVolume_ValueChanged);
            // 
            // DisabledVolume
            // 
            this.DisabledVolume.BackColor = System.Drawing.Color.Transparent;
            this.DisabledVolume.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.DisabledVolume.Location = new System.Drawing.Point(321, 105);
            this.DisabledVolume.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DisabledVolume.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DisabledVolume.Name = "DisabledVolume";
            this.DisabledVolume.Size = new System.Drawing.Size(136, 23);
            this.DisabledVolume.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DisabledVolume.TabIndex = 35;
            this.DisabledVolume.Text = "Disabled Volume: %s%";
            this.DisabledVolume.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.DisabledVolume.ValueDecimals = 2;
            this.DisabledVolume.ValueChanged += new System.EventHandler(this.DisabledVolume_ValueChanged);
            // 
            // ToggleAPassthrough
            // 
            this.ToggleAPassthrough.AutoSize = true;
            this.ToggleAPassthrough.Location = new System.Drawing.Point(150, 43);
            this.ToggleAPassthrough.Name = "ToggleAPassthrough";
            this.ToggleAPassthrough.Size = new System.Drawing.Size(89, 15);
            this.ToggleAPassthrough.TabIndex = 36;
            this.ToggleAPassthrough.Text = "Passthrough";
            this.ToggleAPassthrough.UseSelectable = true;
            this.ToggleAPassthrough.CheckedChanged += new System.EventHandler(this.ToggleAPassthrough_CheckedChanged);
            // 
            // ToggleAAudio
            // 
            this.ToggleAAudio.AutoSize = true;
            this.ToggleAAudio.Location = new System.Drawing.Point(244, 43);
            this.ToggleAAudio.Name = "ToggleAAudio";
            this.ToggleAAudio.Size = new System.Drawing.Size(55, 15);
            this.ToggleAAudio.TabIndex = 37;
            this.ToggleAAudio.Text = "Audio";
            this.ToggleAAudio.UseSelectable = true;
            this.ToggleAAudio.CheckedChanged += new System.EventHandler(this.ToggleAAudio_CheckedChanged);
            // 
            // ToggleBAudio
            // 
            this.ToggleBAudio.AutoSize = true;
            this.ToggleBAudio.Location = new System.Drawing.Point(244, 69);
            this.ToggleBAudio.Name = "ToggleBAudio";
            this.ToggleBAudio.Size = new System.Drawing.Size(55, 15);
            this.ToggleBAudio.TabIndex = 41;
            this.ToggleBAudio.Text = "Audio";
            this.ToggleBAudio.UseSelectable = true;
            this.ToggleBAudio.CheckedChanged += new System.EventHandler(this.ToggleBAudio_CheckedChanged);
            // 
            // ToggleBPassthrough
            // 
            this.ToggleBPassthrough.AutoSize = true;
            this.ToggleBPassthrough.Location = new System.Drawing.Point(150, 69);
            this.ToggleBPassthrough.Name = "ToggleBPassthrough";
            this.ToggleBPassthrough.Size = new System.Drawing.Size(89, 15);
            this.ToggleBPassthrough.TabIndex = 40;
            this.ToggleBPassthrough.Text = "Passthrough";
            this.ToggleBPassthrough.UseSelectable = true;
            this.ToggleBPassthrough.CheckedChanged += new System.EventHandler(this.ToggleBPassthrough_CheckedChanged);
            // 
            // BindingToggleB
            // 
            // 
            // 
            // 
            this.BindingToggleB.CustomButton.Image = null;
            this.BindingToggleB.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.BindingToggleB.CustomButton.Name = "";
            this.BindingToggleB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BindingToggleB.CustomButton.Style = Pri.PriColorStyle.Purple;
            this.BindingToggleB.CustomButton.TabIndex = 4;
            this.BindingToggleB.CustomButton.Theme = Pri.PriThemeStyle.Dark;
            this.BindingToggleB.CustomButton.UseSelectable = true;
            this.BindingToggleB.CustomButton.Visible = false;
            this.BindingToggleB.Lines = new string[] {
        "None"};
            this.BindingToggleB.Location = new System.Drawing.Point(78, 64);
            this.BindingToggleB.MaxLength = 32767;
            this.BindingToggleB.Name = "BindingToggleB";
            this.BindingToggleB.PasswordChar = '\0';
            this.BindingToggleB.ReadOnly = true;
            this.BindingToggleB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BindingToggleB.ScrollBarsNative = System.Windows.Forms.ScrollBars.None;
            this.BindingToggleB.SelectedText = "";
            this.BindingToggleB.SelectionLength = 0;
            this.BindingToggleB.SelectionStart = 0;
            this.BindingToggleB.ShortcutsEnabled = false;
            this.BindingToggleB.Size = new System.Drawing.Size(63, 23);
            this.BindingToggleB.TabIndex = 39;
            this.BindingToggleB.TabStop = false;
            this.BindingToggleB.Text = "None";
            this.BindingToggleB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BindingToggleB.UseSelectable = true;
            this.BindingToggleB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BindingToggleB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BindingToggleB.Click += new System.EventHandler(this.BindingToggleB_Click);
            // 
            // priLabel16
            // 
            this.priLabel16.Location = new System.Drawing.Point(5, 64);
            this.priLabel16.Name = "priLabel16";
            this.priLabel16.Size = new System.Drawing.Size(67, 23);
            this.priLabel16.TabIndex = 38;
            this.priLabel16.Text = "Toggle B";
            this.priLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel17
            // 
            this.priLabel17.Location = new System.Drawing.Point(5, 94);
            this.priLabel17.Name = "priLabel17";
            this.priLabel17.Size = new System.Drawing.Size(136, 27);
            this.priLabel17.TabIndex = 43;
            this.priLabel17.Text = "Mouse Direction";
            this.priLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priLabel18
            // 
            this.priLabel18.Location = new System.Drawing.Point(5, 115);
            this.priLabel18.Name = "priLabel18";
            this.priLabel18.Size = new System.Drawing.Size(136, 27);
            this.priLabel18.TabIndex = 44;
            this.priLabel18.Text = "Skill Bindings";
            this.priLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BindingSkills
            // 
            this.BindingSkills.FontSize = Pri.PriComboBoxSize.Small;
            this.BindingSkills.FormattingEnabled = true;
            this.BindingSkills.ItemHeight = 19;
            this.BindingSkills.Location = new System.Drawing.Point(147, 107);
            this.BindingSkills.Name = "BindingSkills";
            this.BindingSkills.Size = new System.Drawing.Size(92, 25);
            this.BindingSkills.TabIndex = 45;
            this.BindingSkills.UseSelectable = true;
            // 
            // BindingSkillsUpdate
            // 
            this.BindingSkillsUpdate.Location = new System.Drawing.Point(244, 108);
            this.BindingSkillsUpdate.Name = "BindingSkillsUpdate";
            this.BindingSkillsUpdate.Size = new System.Drawing.Size(55, 23);
            this.BindingSkillsUpdate.TabIndex = 46;
            this.BindingSkillsUpdate.Text = "Update";
            this.BindingSkillsUpdate.UseSelectable = true;
            this.BindingSkillsUpdate.Click += new System.EventHandler(this.BindingSkillsUpdate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = Pri.Forms.PriFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(475, 291);
            this.Controls.Add(this.BindingSkillsUpdate);
            this.Controls.Add(this.BindingSkills);
            this.Controls.Add(this.priLabel18);
            this.Controls.Add(this.priLabel17);
            this.Controls.Add(this.ToggleBAudio);
            this.Controls.Add(this.ToggleBPassthrough);
            this.Controls.Add(this.BindingToggleB);
            this.Controls.Add(this.priLabel16);
            this.Controls.Add(this.ToggleAAudio);
            this.Controls.Add(this.ToggleAPassthrough);
            this.Controls.Add(this.DisabledVolume);
            this.Controls.Add(this.EnabledVolume);
            this.Controls.Add(this.ClientTitle);
            this.Controls.Add(this.BindingToggleA);
            this.Controls.Add(this.priLabel15);
            this.Controls.Add(this.BindingBack);
            this.Controls.Add(this.BindingStart);
            this.Controls.Add(this.priLabel13);
            this.Controls.Add(this.BindingUp);
            this.Controls.Add(this.priLabel14);
            this.Controls.Add(this.priLabel5);
            this.Controls.Add(this.BindingR2);
            this.Controls.Add(this.priLabel4);
            this.Controls.Add(this.BindingR1);
            this.Controls.Add(this.priLabel6);
            this.Controls.Add(this.BindingL2);
            this.Controls.Add(this.priLabel3);
            this.Controls.Add(this.BindingL1);
            this.Controls.Add(this.priLabel7);
            this.Controls.Add(this.BindingY);
            this.Controls.Add(this.priLabel2);
            this.Controls.Add(this.BindingX);
            this.Controls.Add(this.priLabel8);
            this.Controls.Add(this.BindingB);
            this.Controls.Add(this.priLabel1);
            this.Controls.Add(this.BindingA);
            this.Controls.Add(this.priLabel10);
            this.Controls.Add(this.BindingRight);
            this.Controls.Add(this.priLabel9);
            this.Controls.Add(this.BindingLeft);
            this.Controls.Add(this.priLabel12);
            this.Controls.Add(this.BindingDown);
            this.Controls.Add(this.priLabel11);
            this.DisplayHeader = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Resizable = false;
            this.Text = "ControllerEmu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.TrayCMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private Pri.Controls.PriContextMenuStrip TrayCMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuToggleConnect;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuExit;
        private System.Windows.Forms.ToolStripMenuItem TrayCMenuReloadConfig;
        private Pri.Controls.PriLabel priLabel1;
        private Pri.Controls.PriLabel priLabel2;
        private Pri.Controls.PriLabel priLabel3;
        private Pri.Controls.PriLabel priLabel4;
        private Pri.Controls.PriLabel priLabel5;
        private Pri.Controls.PriLabel priLabel6;
        private Pri.Controls.PriLabel priLabel7;
        private Pri.Controls.PriLabel priLabel8;
        private Pri.Controls.PriLabel priLabel9;
        private Pri.Controls.PriLabel priLabel10;
        private Pri.Controls.PriLabel priLabel11;
        private Pri.Controls.PriLabel priLabel12;
        private Pri.Controls.PriTextBox BindingUp;
        private Pri.Controls.PriTextBox BindingDown;
        private Pri.Controls.PriTextBox BindingLeft;
        private Pri.Controls.PriTextBox BindingRight;
        private Pri.Controls.PriTextBox BindingY;
        private Pri.Controls.PriTextBox BindingX;
        private Pri.Controls.PriTextBox BindingB;
        private Pri.Controls.PriTextBox BindingA;
        private Pri.Controls.PriTextBox BindingR2;
        private Pri.Controls.PriTextBox BindingR1;
        private Pri.Controls.PriTextBox BindingL2;
        private Pri.Controls.PriTextBox BindingL1;
        private Pri.Controls.PriTextBox BindingBack;
        private Pri.Controls.PriTextBox BindingStart;
        private Pri.Controls.PriLabel priLabel13;
        private Pri.Controls.PriLabel priLabel14;
        private Pri.Controls.PriTextBox BindingToggleA;
        private Pri.Controls.PriLabel priLabel15;
        private Pri.Controls.PriTextBox ClientTitle;
        private Pri.Controls.PriTrackBar EnabledVolume;
        private Pri.Controls.PriTrackBar DisabledVolume;
        private Pri.Controls.PriCheckBox ToggleAPassthrough;
        private Pri.Controls.PriCheckBox ToggleAAudio;
        private Pri.Controls.PriCheckBox ToggleBAudio;
        private Pri.Controls.PriCheckBox ToggleBPassthrough;
        private Pri.Controls.PriTextBox BindingToggleB;
        private Pri.Controls.PriLabel priLabel16;
        private Pri.Controls.PriLabel priLabel17;
        private Pri.Controls.PriLabel priLabel18;
        private Pri.Controls.PriComboBox BindingSkills;
        private Pri.Controls.PriButton BindingSkillsUpdate;
    }
}

