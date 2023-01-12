
namespace focus
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.trayicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayiconmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripShowConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.stripStart = new System.Windows.Forms.ToolStripMenuItem();
            this.stripPause = new System.Windows.Forms.ToolStripMenuItem();
            this.stripStop = new System.Windows.Forms.ToolStripMenuItem();
            this.stripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chkSoundNotification = new System.Windows.Forms.CheckBox();
            this.chkRunWithWindows = new System.Windows.Forms.CheckBox();
            this.chkShowForm = new System.Windows.Forms.CheckBox();
            this.chkRunAsAdmin = new System.Windows.Forms.CheckBox();
            this.numFocus = new System.Windows.Forms.NumericUpDown();
            this.lbFocustime = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.lbRepeat = new System.Windows.Forms.Label();
            this.cboRepeat = new System.Windows.Forms.ComboBox();
            this.lbBreaktime = new System.Windows.Forms.Label();
            this.cboBreaktime = new System.Windows.Forms.ComboBox();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.lbMinuteCon = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.lbPreview = new System.Windows.Forms.Label();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.btnSaveColor = new System.Windows.Forms.Button();
            this.txtPreviewColor = new System.Windows.Forms.TextBox();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.reportProgress = new System.Windows.Forms.ProgressBar();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.lbDependency = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbFunction = new System.Windows.Forms.Label();
            this.colorForm = new System.Windows.Forms.ColorDialog();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLanguage = new System.Windows.Forms.PictureBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.trayiconmenustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFocus)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.tabCustom.SuspendLayout();
            this.panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.tabOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // trayicon
            // 
            this.trayicon.ContextMenuStrip = this.trayiconmenustrip;
            this.trayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayicon.Icon")));
            this.trayicon.Text = "Focus";
            this.trayicon.Visible = true;
            this.trayicon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trayicon_MouseUp);
            // 
            // trayiconmenustrip
            // 
            this.trayiconmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripShowConfig,
            this.stripStart,
            this.stripPause,
            this.stripStop,
            this.stripExit});
            this.trayiconmenustrip.Name = "trayiconmenustrip";
            this.trayiconmenustrip.Size = new System.Drawing.Size(106, 114);
            // 
            // stripShowConfig
            // 
            this.stripShowConfig.Image = global::focus.Properties.Resources.popup;
            this.stripShowConfig.Name = "stripShowConfig";
            this.stripShowConfig.Size = new System.Drawing.Size(105, 22);
            this.stripShowConfig.Text = "Show";
            this.stripShowConfig.Click += new System.EventHandler(this.stripShowConfig_Click);
            // 
            // stripStart
            // 
            this.stripStart.Image = global::focus.Properties.Resources.start;
            this.stripStart.Name = "stripStart";
            this.stripStart.Size = new System.Drawing.Size(105, 22);
            this.stripStart.Text = "Start";
            this.stripStart.Click += new System.EventHandler(this.tripStart_Click);
            // 
            // stripPause
            // 
            this.stripPause.Image = global::focus.Properties.Resources.pause;
            this.stripPause.Name = "stripPause";
            this.stripPause.Size = new System.Drawing.Size(105, 22);
            this.stripPause.Text = "Pause";
            this.stripPause.Click += new System.EventHandler(this.tripPause_Click);
            // 
            // stripStop
            // 
            this.stripStop.Image = global::focus.Properties.Resources.stop;
            this.stripStop.Name = "stripStop";
            this.stripStop.Size = new System.Drawing.Size(105, 22);
            this.stripStop.Text = "Stop";
            this.stripStop.Click += new System.EventHandler(this.tripStop_Click);
            // 
            // stripExit
            // 
            this.stripExit.Image = global::focus.Properties.Resources.exit;
            this.stripExit.Name = "stripExit";
            this.stripExit.Size = new System.Drawing.Size(105, 22);
            this.stripExit.Text = "Exit";
            this.stripExit.Click += new System.EventHandler(this.stripExit_Click);
            // 
            // chkSoundNotification
            // 
            this.chkSoundNotification.AutoSize = true;
            this.chkSoundNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoundNotification.Location = new System.Drawing.Point(8, 116);
            this.chkSoundNotification.Name = "chkSoundNotification";
            this.chkSoundNotification.Size = new System.Drawing.Size(145, 20);
            this.chkSoundNotification.TabIndex = 3;
            this.chkSoundNotification.Text = "Âm thanh thông báo";
            this.chkSoundNotification.UseVisualStyleBackColor = true;
            this.chkSoundNotification.CheckedChanged += new System.EventHandler(this.chkSoundNotification_CheckedChanged);
            // 
            // chkRunWithWindows
            // 
            this.chkRunWithWindows.AutoSize = true;
            this.chkRunWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRunWithWindows.Location = new System.Drawing.Point(8, 44);
            this.chkRunWithWindows.Name = "chkRunWithWindows";
            this.chkRunWithWindows.Size = new System.Drawing.Size(177, 20);
            this.chkRunWithWindows.TabIndex = 1;
            this.chkRunWithWindows.Text = "Khởi động cùng Windows";
            this.chkRunWithWindows.UseVisualStyleBackColor = true;
            this.chkRunWithWindows.CheckedChanged += new System.EventHandler(this.chkRunWithWindows_CheckedChanged);
            // 
            // chkShowForm
            // 
            this.chkShowForm.AutoSize = true;
            this.chkShowForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowForm.Location = new System.Drawing.Point(8, 80);
            this.chkShowForm.Name = "chkShowForm";
            this.chkShowForm.Size = new System.Drawing.Size(137, 20);
            this.chkShowForm.TabIndex = 2;
            this.chkShowForm.Text = "Hiện khi khởi động";
            this.chkShowForm.UseVisualStyleBackColor = true;
            this.chkShowForm.CheckedChanged += new System.EventHandler(this.chkShowForm_CheckedChanged);
            // 
            // chkRunAsAdmin
            // 
            this.chkRunAsAdmin.AutoSize = true;
            this.chkRunAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRunAsAdmin.Location = new System.Drawing.Point(8, 8);
            this.chkRunAsAdmin.Name = "chkRunAsAdmin";
            this.chkRunAsAdmin.Size = new System.Drawing.Size(160, 20);
            this.chkRunAsAdmin.TabIndex = 0;
            this.chkRunAsAdmin.Text = "Chạy với quyền Admin";
            this.chkRunAsAdmin.UseVisualStyleBackColor = true;
            this.chkRunAsAdmin.CheckedChanged += new System.EventHandler(this.chkRunAsAdmin_CheckedChanged);
            // 
            // numFocus
            // 
            this.numFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFocus.Location = new System.Drawing.Point(128, 8);
            this.numFocus.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numFocus.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFocus.Name = "numFocus";
            this.numFocus.Size = new System.Drawing.Size(49, 22);
            this.numFocus.TabIndex = 0;
            this.numFocus.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbFocustime
            // 
            this.lbFocustime.AutoSize = true;
            this.lbFocustime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFocustime.Location = new System.Drawing.Point(6, 10);
            this.lbFocustime.Name = "lbFocustime";
            this.lbFocustime.Size = new System.Drawing.Size(118, 16);
            this.lbFocustime.TabIndex = 8;
            this.lbFocustime.Text = "Thời gian tập trung";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConfig);
            this.tabControl.Controls.Add(this.tabSystem);
            this.tabControl.Controls.Add(this.tabCustom);
            this.tabControl.Controls.Add(this.tabOther);
            this.tabControl.Location = new System.Drawing.Point(2, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(250, 235);
            this.tabControl.TabIndex = 0;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.lbRepeat);
            this.tabConfig.Controls.Add(this.cboRepeat);
            this.tabConfig.Controls.Add(this.lbBreaktime);
            this.tabConfig.Controls.Add(this.cboBreaktime);
            this.tabConfig.Controls.Add(this.lbCountDown);
            this.tabConfig.Controls.Add(this.btnSetTime);
            this.tabConfig.Controls.Add(this.lbMinuteCon);
            this.tabConfig.Controls.Add(this.lbFocustime);
            this.tabConfig.Controls.Add(this.btnStop);
            this.tabConfig.Controls.Add(this.numFocus);
            this.tabConfig.Controls.Add(this.btnStart);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(242, 209);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "Cấu hình";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // lbRepeat
            // 
            this.lbRepeat.AutoSize = true;
            this.lbRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepeat.Location = new System.Drawing.Point(6, 75);
            this.lbRepeat.Name = "lbRepeat";
            this.lbRepeat.Size = new System.Drawing.Size(48, 16);
            this.lbRepeat.TabIndex = 17;
            this.lbRepeat.Text = "Lặp lại";
            // 
            // cboRepeat
            // 
            this.cboRepeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRepeat.FormattingEnabled = true;
            this.cboRepeat.Location = new System.Drawing.Point(128, 72);
            this.cboRepeat.Name = "cboRepeat";
            this.cboRepeat.Size = new System.Drawing.Size(100, 24);
            this.cboRepeat.TabIndex = 2;
            this.cboRepeat.SelectedIndexChanged += new System.EventHandler(this.cboRepeat_SelectedIndexChanged);
            // 
            // lbBreaktime
            // 
            this.lbBreaktime.AutoSize = true;
            this.lbBreaktime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBreaktime.Location = new System.Drawing.Point(6, 41);
            this.lbBreaktime.Name = "lbBreaktime";
            this.lbBreaktime.Size = new System.Drawing.Size(92, 16);
            this.lbBreaktime.TabIndex = 15;
            this.lbBreaktime.Text = "Thời gian nghỉ";
            // 
            // cboBreaktime
            // 
            this.cboBreaktime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBreaktime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBreaktime.FormattingEnabled = true;
            this.cboBreaktime.Location = new System.Drawing.Point(128, 39);
            this.cboBreaktime.Name = "cboBreaktime";
            this.cboBreaktime.Size = new System.Drawing.Size(100, 24);
            this.cboBreaktime.TabIndex = 1;
            this.cboBreaktime.SelectedIndexChanged += new System.EventHandler(this.cboBreaktime_SelectedIndexChanged);
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.Location = new System.Drawing.Point(20, 145);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(164, 42);
            this.lbCountDown.TabIndex = 13;
            this.lbCountDown.Text = "00:00:00";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(9, 118);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(64, 23);
            this.btnSetTime.TabIndex = 3;
            this.btnSetTime.Text = "Set time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // lbMinuteCon
            // 
            this.lbMinuteCon.AutoSize = true;
            this.lbMinuteCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinuteCon.Location = new System.Drawing.Point(180, 10);
            this.lbMinuteCon.Name = "lbMinuteCon";
            this.lbMinuteCon.Size = new System.Drawing.Size(34, 16);
            this.lbMinuteCon.TabIndex = 10;
            this.lbMinuteCon.Text = "Phút";
            // 
            // btnStop
            // 
            this.btnStop.Image = global::focus.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(201, 154);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 35);
            this.btnStop.TabIndex = 5;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::focus.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(201, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(35, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.chkSoundNotification);
            this.tabSystem.Controls.Add(this.chkRunWithWindows);
            this.tabSystem.Controls.Add(this.chkRunAsAdmin);
            this.tabSystem.Controls.Add(this.chkShowForm);
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(242, 209);
            this.tabSystem.TabIndex = 1;
            this.tabSystem.Text = "Hệ thống";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.lbPreview);
            this.tabCustom.Controls.Add(this.btnChangeImage);
            this.tabCustom.Controls.Add(this.panelPreview);
            this.tabCustom.Controls.Add(this.btnSaveColor);
            this.tabCustom.Controls.Add(this.txtPreviewColor);
            this.tabCustom.Controls.Add(this.btnSetColor);
            this.tabCustom.Location = new System.Drawing.Point(4, 22);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustom.Size = new System.Drawing.Size(242, 209);
            this.tabCustom.TabIndex = 2;
            this.tabCustom.Text = "Tuỳ chỉnh";
            this.tabCustom.UseVisualStyleBackColor = true;
            // 
            // lbPreview
            // 
            this.lbPreview.AutoSize = true;
            this.lbPreview.Location = new System.Drawing.Point(9, 76);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(55, 13);
            this.lbPreview.TabIndex = 5;
            this.lbPreview.Text = "Xem trước";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(9, 40);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(225, 23);
            this.btnChangeImage.TabIndex = 3;
            this.btnChangeImage.Text = "Đổi hình nền chờ";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.Black;
            this.panelPreview.Controls.Add(this.picturePreview);
            this.panelPreview.Location = new System.Drawing.Point(6, 95);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(230, 100);
            this.panelPreview.TabIndex = 4;
            // 
            // picturePreview
            // 
            this.picturePreview.BackColor = System.Drawing.Color.White;
            this.picturePreview.Location = new System.Drawing.Point(2, 2);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(226, 96);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 0;
            this.picturePreview.TabStop = false;
            // 
            // btnSaveColor
            // 
            this.btnSaveColor.Location = new System.Drawing.Point(190, 8);
            this.btnSaveColor.Name = "btnSaveColor";
            this.btnSaveColor.Size = new System.Drawing.Size(44, 23);
            this.btnSaveColor.TabIndex = 2;
            this.btnSaveColor.Text = "Lưu";
            this.btnSaveColor.UseVisualStyleBackColor = true;
            this.btnSaveColor.Click += new System.EventHandler(this.btnSaveColor_Click);
            // 
            // txtPreviewColor
            // 
            this.txtPreviewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreviewColor.Enabled = false;
            this.txtPreviewColor.Location = new System.Drawing.Point(91, 9);
            this.txtPreviewColor.Name = "txtPreviewColor";
            this.txtPreviewColor.Size = new System.Drawing.Size(79, 20);
            this.txtPreviewColor.TabIndex = 1;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(8, 8);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(63, 23);
            this.btnSetColor.TabIndex = 0;
            this.btnSetColor.Text = "Đặt màu";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.reportProgress);
            this.tabOther.Controls.Add(this.btnReport);
            this.tabOther.Controls.Add(this.btnTea);
            this.tabOther.Controls.Add(this.lbDependency);
            this.tabOther.Controls.Add(this.lbTime);
            this.tabOther.Controls.Add(this.lbAuthor);
            this.tabOther.Controls.Add(this.lbFunction);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(242, 209);
            this.tabOther.TabIndex = 3;
            this.tabOther.Text = "Khác";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // reportProgress
            // 
            this.reportProgress.Location = new System.Drawing.Point(8, 151);
            this.reportProgress.Name = "reportProgress";
            this.reportProgress.Size = new System.Drawing.Size(226, 23);
            this.reportProgress.Step = 5;
            this.reportProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.reportProgress.TabIndex = 6;
            this.reportProgress.Visible = false;
            // 
            // btnReport
            // 
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(8, 151);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(226, 23);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTea
            // 
            this.btnTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTea.Location = new System.Drawing.Point(8, 180);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(226, 23);
            this.btnTea.TabIndex = 4;
            this.btnTea.Text = "Buy me a cup of cold tea!";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // lbDependency
            // 
            this.lbDependency.AutoSize = true;
            this.lbDependency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDependency.Location = new System.Drawing.Point(4, 88);
            this.lbDependency.Name = "lbDependency";
            this.lbDependency.Size = new System.Drawing.Size(237, 13);
            this.lbDependency.TabIndex = 3;
            this.lbDependency.Text = "* Dependency: .Net Framework 4.7.2 and above";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(4, 62);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(95, 13);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "* Time: 1/12/2022";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(4, 36);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(98, 13);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "* Author: KameDev";
            // 
            // lbFunction
            // 
            this.lbFunction.AutoSize = true;
            this.lbFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunction.Location = new System.Drawing.Point(4, 10);
            this.lbFunction.Name = "lbFunction";
            this.lbFunction.Size = new System.Drawing.Size(127, 13);
            this.lbFunction.TabIndex = 0;
            this.lbFunction.Text = "* Function: Used to focus";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::focus.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(205, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::focus.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(230, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 22);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLanguage
            // 
            this.picLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLanguage.Image = global::focus.Properties.Resources.VI;
            this.picLanguage.Location = new System.Drawing.Point(6, 6);
            this.picLanguage.Name = "picLanguage";
            this.picLanguage.Size = new System.Drawing.Size(22, 14);
            this.picLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLanguage.TabIndex = 2;
            this.picLanguage.TabStop = false;
            this.picLanguage.Click += new System.EventHandler(this.picLanguage_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(254, 263);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Focus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.trayiconmenustrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFocus)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.tabSystem.PerformLayout();
            this.tabCustom.ResumeLayout(false);
            this.tabCustom.PerformLayout();
            this.panelPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayicon;
        private System.Windows.Forms.ContextMenuStrip trayiconmenustrip;
        private System.Windows.Forms.ToolStripMenuItem stripShowConfig;
        private System.Windows.Forms.ToolStripMenuItem stripExit;
        private System.Windows.Forms.PictureBox picLanguage;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.CheckBox chkRunAsAdmin;
        private System.Windows.Forms.CheckBox chkSoundNotification;
        private System.Windows.Forms.CheckBox chkRunWithWindows;
        private System.Windows.Forms.CheckBox chkShowForm;
        private System.Windows.Forms.Label lbFocustime;
        private System.Windows.Forms.NumericUpDown numFocus;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.Label lbMinuteCon;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Label lbBreaktime;
        private System.Windows.Forms.ComboBox cboBreaktime;
        private System.Windows.Forms.Label lbRepeat;
        private System.Windows.Forms.ComboBox cboRepeat;
        private System.Windows.Forms.TabPage tabCustom;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.ColorDialog colorForm;
        private System.Windows.Forms.TextBox txtPreviewColor;
        private System.Windows.Forms.Button btnSaveColor;
        private System.Windows.Forms.ToolStripMenuItem stripStart;
        private System.Windows.Forms.ToolStripMenuItem stripPause;
        private System.Windows.Forms.ToolStripMenuItem stripStop;
        private System.Windows.Forms.Label lbPreview;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Label lbDependency;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbFunction;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ProgressBar reportProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        public System.Windows.Forms.Button btnStart;
    }
}