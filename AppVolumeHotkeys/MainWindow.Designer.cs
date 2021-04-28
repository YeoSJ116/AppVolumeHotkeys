namespace AppVolumeHotkeys
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label_Description4 = new System.Windows.Forms.Label();
            this.lblAppVolume = new System.Windows.Forms.Label();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemVolUp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVolDown = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_ptt = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.F1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.panel9 = new System.Windows.Forms.Panel();
            this.F12 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.F8 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.F11 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.F4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.F10 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.F7 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.F9 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.F3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.F6 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.F2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.F5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Description3 = new System.Windows.Forms.Label();
            this.nudVolumeSteps = new System.Windows.Forms.NumericUpDown();
            this.btnSaveHotkeys = new System.Windows.Forms.Button();
            this.btnResetHotkeys = new System.Windows.Forms.Button();
            this.cmbAppName = new System.Windows.Forms.ComboBox();
            this.btnAppNameRefresh = new System.Windows.Forms.Button();
            this.cmbEndpoints = new System.Windows.Forms.ComboBox();
            this.btnEndpointsRefresh = new System.Windows.Forms.Button();
            this.nudSoftMuteLevel = new System.Windows.Forms.NumericUpDown();
            this.label_SoftMuteSteps = new System.Windows.Forms.Label();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.comboKey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lnkCostura = new System.Windows.Forms.LinkLabel();
            this.lnkFody = new System.Windows.Forms.LinkLabel();
            this.lnkCSCore = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmsTray.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumeSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoftMuteLevel)).BeginInit();
            this.groupBox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Description4
            // 
            this.label_Description4.AutoSize = true;
            this.label_Description4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Description4.Location = new System.Drawing.Point(15, 91);
            this.label_Description4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description4.Name = "label_Description4";
            this.label_Description4.Size = new System.Drawing.Size(45, 13);
            this.label_Description4.TabIndex = 5;
            this.label_Description4.Text = "Volume:";
            // 
            // lblAppVolume
            // 
            this.lblAppVolume.AutoSize = true;
            this.lblAppVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAppVolume.Location = new System.Drawing.Point(59, 91);
            this.lblAppVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppVolume.Name = "lblAppVolume";
            this.lblAppVolume.Size = new System.Drawing.Size(25, 13);
            this.lblAppVolume.TabIndex = 6;
            this.lblAppVolume.Text = "100";
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Interval = 500;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Program volume controller";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // cmsTray
            // 
            this.cmsTray.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.toolStripSeparator1,
            this.itemVolUp,
            this.itemVolDown,
            this.itemMute,
            this.toolStripSeparator3,
            this.itemExit});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(153, 126);
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(152, 22);
            this.itemOpen.Text = "Open";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // itemVolUp
            // 
            this.itemVolUp.Name = "itemVolUp";
            this.itemVolUp.Size = new System.Drawing.Size(152, 22);
            this.itemVolUp.Text = "Volume Up";
            this.itemVolUp.Click += new System.EventHandler(this.itemVolUp_Click);
            // 
            // itemVolDown
            // 
            this.itemVolDown.Name = "itemVolDown";
            this.itemVolDown.Size = new System.Drawing.Size(152, 22);
            this.itemVolDown.Text = "Volume Down";
            this.itemVolDown.Click += new System.EventHandler(this.itemVolDown_Click);
            // 
            // itemMute
            // 
            this.itemMute.Name = "itemMute";
            this.itemMute.Size = new System.Drawing.Size(152, 22);
            this.itemMute.Text = "Toggle Mute";
            this.itemMute.Click += new System.EventHandler(this.itemMute_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(152, 22);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // timer_ptt
            // 
            this.timer_ptt.Enabled = true;
            this.timer_ptt.Tick += new System.EventHandler(this.timer_ptt_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "F1";
            // 
            // F1
            // 
            this.F1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F1.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F1.FormattingEnabled = true;
            this.F1.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F1.Location = new System.Drawing.Point(4, 20);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(48, 34);
            this.F1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.F1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboKey);
            this.groupBox1.Controls.Add(this.panel13);
            this.groupBox1.Controls.Add(this.label_Description4);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.lblAppVolume);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel12);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 121);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkey mapping";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.trackVolume);
            this.panel13.Location = new System.Drawing.Point(85, 82);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(545, 33);
            this.panel13.TabIndex = 27;
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(0, 4);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(545, 45);
            this.trackVolume.TabIndex = 26;
            this.trackVolume.Value = 100;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.F12);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(768, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(60, 60);
            this.panel9.TabIndex = 18;
            // 
            // F12
            // 
            this.F12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F12.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F12.FormattingEnabled = true;
            this.F12.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F12.Location = new System.Drawing.Point(4, 20);
            this.F12.Name = "F12";
            this.F12.Size = new System.Drawing.Size(48, 34);
            this.F12.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(12, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "F12";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.F8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(490, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 60);
            this.panel5.TabIndex = 18;
            // 
            // F8
            // 
            this.F8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F8.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F8.FormattingEnabled = true;
            this.F8.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F8.Location = new System.Drawing.Point(4, 20);
            this.F8.Name = "F8";
            this.F8.Size = new System.Drawing.Size(48, 34);
            this.F8.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(16, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "F8";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.F11);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Location = new System.Drawing.Point(702, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(60, 60);
            this.panel10.TabIndex = 19;
            // 
            // F11
            // 
            this.F11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F11.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F11.FormattingEnabled = true;
            this.F11.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F11.Location = new System.Drawing.Point(4, 20);
            this.F11.Name = "F11";
            this.F11.Size = new System.Drawing.Size(48, 34);
            this.F11.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(13, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "F11";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.F4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(210, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 60);
            this.panel4.TabIndex = 16;
            // 
            // F4
            // 
            this.F4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F4.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F4.FormattingEnabled = true;
            this.F4.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F4.Location = new System.Drawing.Point(4, 20);
            this.F4.Name = "F4";
            this.F4.Size = new System.Drawing.Size(48, 34);
            this.F4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(16, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "F4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Combine key";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.F10);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Location = new System.Drawing.Point(636, 20);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(60, 60);
            this.panel11.TabIndex = 20;
            // 
            // F10
            // 
            this.F10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F10.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F10.FormattingEnabled = true;
            this.F10.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F10.Location = new System.Drawing.Point(4, 20);
            this.F10.Name = "F10";
            this.F10.Size = new System.Drawing.Size(48, 34);
            this.F10.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(12, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "F10";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.F7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(424, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 60);
            this.panel6.TabIndex = 19;
            // 
            // F7
            // 
            this.F7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F7.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F7.FormattingEnabled = true;
            this.F7.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F7.Location = new System.Drawing.Point(4, 20);
            this.F7.Name = "F7";
            this.F7.Size = new System.Drawing.Size(48, 34);
            this.F7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(16, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "F7";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.F9);
            this.panel12.Controls.Add(this.label14);
            this.panel12.Location = new System.Drawing.Point(570, 20);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(60, 60);
            this.panel12.TabIndex = 17;
            // 
            // F9
            // 
            this.F9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F9.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F9.FormattingEnabled = true;
            this.F9.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F9.Location = new System.Drawing.Point(4, 20);
            this.F9.Name = "F9";
            this.F9.Size = new System.Drawing.Size(48, 34);
            this.F9.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(16, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "F9";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.F3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(144, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 60);
            this.panel3.TabIndex = 16;
            // 
            // F3
            // 
            this.F3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F3.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F3.FormattingEnabled = true;
            this.F3.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F3.Location = new System.Drawing.Point(4, 20);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(48, 34);
            this.F3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "F3";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.F6);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(358, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 60);
            this.panel7.TabIndex = 20;
            // 
            // F6
            // 
            this.F6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F6.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F6.FormattingEnabled = true;
            this.F6.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F6.Location = new System.Drawing.Point(4, 20);
            this.F6.Name = "F6";
            this.F6.Size = new System.Drawing.Size(48, 34);
            this.F6.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(16, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "F6";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.F2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(78, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 60);
            this.panel2.TabIndex = 16;
            // 
            // F2
            // 
            this.F2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F2.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F2.FormattingEnabled = true;
            this.F2.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F2.Location = new System.Drawing.Point(4, 20);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(48, 34);
            this.F2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(16, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "F2";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.F5);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(292, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(60, 60);
            this.panel8.TabIndex = 17;
            // 
            // F5
            // 
            this.F5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F5.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.F5.FormattingEnabled = true;
            this.F5.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.F5.Location = new System.Drawing.Point(4, 20);
            this.F5.Name = "F5";
            this.F5.Size = new System.Drawing.Size(48, 34);
            this.F5.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(16, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "F5";
            // 
            // label_Description3
            // 
            this.label_Description3.AutoSize = true;
            this.label_Description3.Location = new System.Drawing.Point(247, 72);
            this.label_Description3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description3.Name = "label_Description3";
            this.label_Description3.Size = new System.Drawing.Size(104, 12);
            this.label_Description3.TabIndex = 5;
            this.label_Description3.Text = "Volume step size";
            // 
            // nudVolumeSteps
            // 
            this.nudVolumeSteps.Location = new System.Drawing.Point(359, 68);
            this.nudVolumeSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudVolumeSteps.Name = "nudVolumeSteps";
            this.nudVolumeSteps.Size = new System.Drawing.Size(46, 21);
            this.nudVolumeSteps.TabIndex = 6;
            this.nudVolumeSteps.TabStop = false;
            this.nudVolumeSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudVolumeSteps.ValueChanged += new System.EventHandler(this.numericUpDown_VolumeSteps_ValueChanged);
            this.nudVolumeSteps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_VolumeSteps_KeyDown);
            // 
            // btnSaveHotkeys
            // 
            this.btnSaveHotkeys.Location = new System.Drawing.Point(413, 68);
            this.btnSaveHotkeys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveHotkeys.Name = "btnSaveHotkeys";
            this.btnSaveHotkeys.Size = new System.Drawing.Size(109, 21);
            this.btnSaveHotkeys.TabIndex = 12;
            this.btnSaveHotkeys.TabStop = false;
            this.btnSaveHotkeys.Text = "Save Hotkeys";
            this.btnSaveHotkeys.UseVisualStyleBackColor = true;
            this.btnSaveHotkeys.Click += new System.EventHandler(this.button_SaveHotkeys_Click);
            // 
            // btnResetHotkeys
            // 
            this.btnResetHotkeys.Location = new System.Drawing.Point(413, 96);
            this.btnResetHotkeys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResetHotkeys.Name = "btnResetHotkeys";
            this.btnResetHotkeys.Size = new System.Drawing.Size(109, 21);
            this.btnResetHotkeys.TabIndex = 13;
            this.btnResetHotkeys.TabStop = false;
            this.btnResetHotkeys.Text = "Reset Hotkeys";
            this.btnResetHotkeys.UseVisualStyleBackColor = true;
            this.btnResetHotkeys.Click += new System.EventHandler(this.button_ResetHotkeys_Click);
            // 
            // cmbAppName
            // 
            this.cmbAppName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppName.FormattingEnabled = true;
            this.cmbAppName.Location = new System.Drawing.Point(67, 40);
            this.cmbAppName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbAppName.Name = "cmbAppName";
            this.cmbAppName.Size = new System.Drawing.Size(420, 20);
            this.cmbAppName.TabIndex = 18;
            this.cmbAppName.TabStop = false;
            this.cmbAppName.SelectedIndexChanged += new System.EventHandler(this.cmbAppName_SelectedIndexChanged);
            // 
            // btnAppNameRefresh
            // 
            this.btnAppNameRefresh.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAppNameRefresh.Location = new System.Drawing.Point(495, 40);
            this.btnAppNameRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAppNameRefresh.Name = "btnAppNameRefresh";
            this.btnAppNameRefresh.Size = new System.Drawing.Size(27, 21);
            this.btnAppNameRefresh.TabIndex = 1;
            this.btnAppNameRefresh.TabStop = false;
            this.btnAppNameRefresh.Text = "Q";
            this.btnAppNameRefresh.UseVisualStyleBackColor = true;
            this.btnAppNameRefresh.Click += new System.EventHandler(this.btnAppNameRefresh_Click);
            // 
            // cmbEndpoints
            // 
            this.cmbEndpoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndpoints.DropDownWidth = 206;
            this.cmbEndpoints.FormattingEnabled = true;
            this.cmbEndpoints.Location = new System.Drawing.Point(67, 17);
            this.cmbEndpoints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEndpoints.Name = "cmbEndpoints";
            this.cmbEndpoints.Size = new System.Drawing.Size(420, 20);
            this.cmbEndpoints.TabIndex = 19;
            this.cmbEndpoints.TabStop = false;
            this.cmbEndpoints.SelectedIndexChanged += new System.EventHandler(this.cmbEndpoints_SelectedIndexChanged);
            // 
            // btnEndpointsRefresh
            // 
            this.btnEndpointsRefresh.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Bold);
            this.btnEndpointsRefresh.Location = new System.Drawing.Point(495, 16);
            this.btnEndpointsRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEndpointsRefresh.Name = "btnEndpointsRefresh";
            this.btnEndpointsRefresh.Size = new System.Drawing.Size(27, 21);
            this.btnEndpointsRefresh.TabIndex = 20;
            this.btnEndpointsRefresh.Text = "Q";
            this.btnEndpointsRefresh.UseVisualStyleBackColor = true;
            this.btnEndpointsRefresh.Click += new System.EventHandler(this.btnEndpointsRefresh_Click);
            // 
            // nudSoftMuteLevel
            // 
            this.nudSoftMuteLevel.Location = new System.Drawing.Point(359, 96);
            this.nudSoftMuteLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoftMuteLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudSoftMuteLevel.Name = "nudSoftMuteLevel";
            this.nudSoftMuteLevel.Size = new System.Drawing.Size(46, 21);
            this.nudSoftMuteLevel.TabIndex = 23;
            this.nudSoftMuteLevel.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSoftMuteLevel.ValueChanged += new System.EventHandler(this.nudSoftMuteLevel_ValueChanged);
            this.nudSoftMuteLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudSoftMuteLevel_KeyDown);
            // 
            // label_SoftMuteSteps
            // 
            this.label_SoftMuteSteps.AutoSize = true;
            this.label_SoftMuteSteps.Location = new System.Drawing.Point(288, 100);
            this.label_SoftMuteSteps.Name = "label_SoftMuteSteps";
            this.label_SoftMuteSteps.Size = new System.Drawing.Size(63, 12);
            this.label_SoftMuteSteps.TabIndex = 24;
            this.label_SoftMuteSteps.Text = "PTT Level";
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.label19);
            this.groupBox_Settings.Controls.Add(this.label17);
            this.groupBox_Settings.Controls.Add(this.label_SoftMuteSteps);
            this.groupBox_Settings.Controls.Add(this.nudSoftMuteLevel);
            this.groupBox_Settings.Controls.Add(this.btnEndpointsRefresh);
            this.groupBox_Settings.Controls.Add(this.cmbEndpoints);
            this.groupBox_Settings.Controls.Add(this.btnAppNameRefresh);
            this.groupBox_Settings.Controls.Add(this.cmbAppName);
            this.groupBox_Settings.Controls.Add(this.btnResetHotkeys);
            this.groupBox_Settings.Controls.Add(this.btnSaveHotkeys);
            this.groupBox_Settings.Controls.Add(this.nudVolumeSteps);
            this.groupBox_Settings.Controls.Add(this.label_Description3);
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 139);
            this.groupBox_Settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_Settings.Size = new System.Drawing.Size(530, 127);
            this.groupBox_Settings.TabIndex = 2;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // comboKey
            // 
            this.comboKey.Location = new System.Drawing.Point(725, 87);
            this.comboKey.Name = "comboKey";
            this.comboKey.Size = new System.Drawing.Size(103, 21);
            this.comboKey.TabIndex = 28;
            this.comboKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboKey_KeyUp);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 26;
            this.label19.Text = "Program";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "Device";
            // 
            // lnkCostura
            // 
            this.lnkCostura.AutoSize = true;
            this.lnkCostura.Location = new System.Drawing.Point(735, 251);
            this.lnkCostura.Name = "lnkCostura";
            this.lnkCostura.Size = new System.Drawing.Size(76, 12);
            this.lnkCostura.TabIndex = 24;
            this.lnkCostura.TabStop = true;
            this.lnkCostura.Text = "MIT License";
            // 
            // lnkFody
            // 
            this.lnkFody.AutoSize = true;
            this.lnkFody.Location = new System.Drawing.Point(683, 236);
            this.lnkFody.Name = "lnkFody";
            this.lnkFody.Size = new System.Drawing.Size(76, 12);
            this.lnkFody.TabIndex = 23;
            this.lnkFody.TabStop = true;
            this.lnkFody.Text = "MIT License";
            // 
            // lnkCSCore
            // 
            this.lnkCSCore.AutoSize = true;
            this.lnkCSCore.Location = new System.Drawing.Point(648, 222);
            this.lnkCSCore.Name = "lnkCSCore";
            this.lnkCSCore.Size = new System.Drawing.Size(145, 12);
            this.lnkCSCore.TabIndex = 22;
            this.lnkCSCore.TabStop = true;
            this.lnkCSCore.Text = "Microsoft Public License";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fody Costura by Simon Cropp: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(549, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "Fody by Simon Cropp: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(549, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "CSCore by filoe: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(549, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(291, 72);
            this.label18.TabIndex = 17;
            this.label18.Text = "Program volume controller v0.0.1U (Univ. report)\r\nCopyright (c) 2021 by \"Yeo Sang" +
    "-Jun (YeoSJ116)\".\r\nForked on \"razorlikes/AppVolumeHotkeys\"\r\nReleased under the M" +
    "IT License.\r\n\r\nOpen source licenses:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 276);
            this.Controls.Add(this.lnkCostura);
            this.Controls.Add(this.lnkFody);
            this.Controls.Add(this.lnkCSCore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Settings);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Program volume controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.cmsTray.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumeSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoftMuteLevel)).EndInit();
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Description4;
        private System.Windows.Forms.Label lblAppVolume;
        private System.Windows.Forms.Timer timer_Refresh;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemMute;
        private System.Windows.Forms.ToolStripMenuItem itemVolUp;
        private System.Windows.Forms.ToolStripMenuItem itemVolDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer_ptt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox F1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox F12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox F8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox F11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox F4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox F10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox F7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox F9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox F3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox F6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox F2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox F5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Description3;
        private System.Windows.Forms.NumericUpDown nudVolumeSteps;
        private System.Windows.Forms.Button btnSaveHotkeys;
        private System.Windows.Forms.Button btnResetHotkeys;
        private System.Windows.Forms.ComboBox cmbAppName;
        private System.Windows.Forms.Button btnAppNameRefresh;
        private System.Windows.Forms.ComboBox cmbEndpoints;
        private System.Windows.Forms.Button btnEndpointsRefresh;
        private System.Windows.Forms.NumericUpDown nudSoftMuteLevel;
        private System.Windows.Forms.Label label_SoftMuteSteps;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.LinkLabel lnkCostura;
        private System.Windows.Forms.LinkLabel lnkFody;
        private System.Windows.Forms.LinkLabel lnkCSCore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.TextBox comboKey;
    }
}

