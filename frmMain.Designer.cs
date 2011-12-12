namespace SOTVVideoUploader
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenerateThumbs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThumbsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFileOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGenerateThumbnails = new System.Windows.Forms.ToolStripButton();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.mplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.ofdOpenMovie = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilename = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUploadName = new System.Windows.Forms.TextBox();
            this.btnCaptureNow = new System.Windows.Forms.Button();
            this.lblUploadName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbMainThumb = new System.Windows.Forms.PictureBox();
            this.lblMainTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flThumbs = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsThumbnails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьНеотмеченныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainThumb)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.cmsThumbnails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileOpen,
            this.tsmiQuit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiFileOpen
            // 
            this.tsmiFileOpen.Image = global::SOTVVideoUploader.Properties.Resources.OpenFile;
            this.tsmiFileOpen.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmiFileOpen.Name = "tsmiFileOpen";
            this.tsmiFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiFileOpen.Size = new System.Drawing.Size(164, 22);
            this.tsmiFileOpen.Text = "Открыть";
            this.tsmiFileOpen.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiQuit.Size = new System.Drawing.Size(164, 22);
            this.tsmiQuit.Text = "Выход";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGenerateThumbs,
            this.tsmiUpload});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // tsmiGenerateThumbs
            // 
            this.tsmiGenerateThumbs.Enabled = false;
            this.tsmiGenerateThumbs.Image = global::SOTVVideoUploader.Properties.Resources.GenVideoDoc_16x16_72;
            this.tsmiGenerateThumbs.Name = "tsmiGenerateThumbs";
            this.tsmiGenerateThumbs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmiGenerateThumbs.Size = new System.Drawing.Size(266, 22);
            this.tsmiGenerateThumbs.Text = "Сгенерировать скриншоты";
            this.tsmiGenerateThumbs.Click += new System.EventHandler(this.tsmiGenerateThumbs_Click);
            // 
            // tsmiUpload
            // 
            this.tsmiUpload.Enabled = false;
            this.tsmiUpload.Image = global::SOTVVideoUploader.Properties.Resources.Webcontrol_Fileupload;
            this.tsmiUpload.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmiUpload.Name = "tsmiUpload";
            this.tsmiUpload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmiUpload.Size = new System.Drawing.Size(266, 22);
            this.tsmiUpload.Text = "Загрузить на сервер";
            this.tsmiUpload.Click += new System.EventHandler(this.tsmiUpload_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAppSettings});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // tsmiAppSettings
            // 
            this.tsmiAppSettings.Image = global::SOTVVideoUploader.Properties.Resources.settings_16;
            this.tsmiAppSettings.Name = "tsmiAppSettings";
            this.tsmiAppSettings.Size = new System.Drawing.Size(207, 22);
            this.tsmiAppSettings.Text = "Настройки приложения";
            this.tsmiAppSettings.Click += new System.EventHandler(this.tsmiAppSettings_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThumbsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblThumbsCount
            // 
            this.lblThumbsCount.Name = "lblThumbsCount";
            this.lblThumbsCount.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileOpen,
            this.toolStripSeparator2,
            this.btnGenerateThumbnails,
            this.btnUpload,
            this.toolStripSeparator1,
            this.btnSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(702, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileOpen.Image = global::SOTVVideoUploader.Properties.Resources.OpenFile;
            this.btnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(23, 22);
            this.btnFileOpen.Text = "Открыть файл";
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGenerateThumbnails
            // 
            this.btnGenerateThumbnails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGenerateThumbnails.Enabled = false;
            this.btnGenerateThumbnails.Image = global::SOTVVideoUploader.Properties.Resources.GenVideoDoc_16x16_72;
            this.btnGenerateThumbnails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateThumbnails.Name = "btnGenerateThumbnails";
            this.btnGenerateThumbnails.Size = new System.Drawing.Size(23, 22);
            this.btnGenerateThumbnails.Text = "Сгенерировать скриншоты";
            this.btnGenerateThumbnails.Click += new System.EventHandler(this.btnGenerateThumbnails_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpload.Enabled = false;
            this.btnUpload.Image = global::SOTVVideoUploader.Properties.Resources.Webcontrol_Fileupload;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(23, 22);
            this.btnUpload.Text = "Загрузить на сервер";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = global::SOTVVideoUploader.Properties.Resources.settings_16;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Text = "Настройки";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(17, 70);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(311, 21);
            this.cmbCategories.TabIndex = 3;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(14, 54);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(60, 13);
            this.lblCategories.TabIndex = 4;
            this.lblCategories.Text = "Категория";
            this.lblCategories.Click += new System.EventHandler(this.lblCategories_Click);
            // 
            // mplayer
            // 
            this.mplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mplayer.Enabled = true;
            this.mplayer.Location = new System.Drawing.Point(20, 28);
            this.mplayer.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.mplayer.Name = "mplayer";
            this.mplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mplayer.OcxState")));
            this.mplayer.Size = new System.Drawing.Size(311, 178);
            this.mplayer.TabIndex = 0;
            // 
            // ofdOpenMovie
            // 
            this.ofdOpenMovie.Filter = "Видеофайлы|*.mov;*.mp4|Все файлы|*.*";
            this.ofdOpenMovie.Title = "Выберите файл";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblFilename, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mplayer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 394);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblFilename
            // 
            this.lblFilename.AllowDrop = true;
            this.lblFilename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(20, 6);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(0, 13);
            this.lblFilename.TabIndex = 6;
            this.lblFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.lblFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.txtUploadName);
            this.panel1.Controls.Add(this.btnCaptureNow);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.lblUploadName);
            this.panel1.Controls.Add(this.lblCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 179);
            this.panel1.TabIndex = 8;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            // 
            // txtUploadName
            // 
            this.txtUploadName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUploadName.Location = new System.Drawing.Point(17, 110);
            this.txtUploadName.Name = "txtUploadName";
            this.txtUploadName.Size = new System.Drawing.Size(311, 20);
            this.txtUploadName.TabIndex = 7;
            // 
            // btnCaptureNow
            // 
            this.btnCaptureNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptureNow.Image = global::SOTVVideoUploader.Properties.Resources.GenVideoDoc_16x16_72;
            this.btnCaptureNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaptureNow.Location = new System.Drawing.Point(229, 3);
            this.btnCaptureNow.Name = "btnCaptureNow";
            this.btnCaptureNow.Size = new System.Drawing.Size(99, 35);
            this.btnCaptureNow.TabIndex = 5;
            this.btnCaptureNow.Text = "Сделать скриншот";
            this.btnCaptureNow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaptureNow.UseVisualStyleBackColor = true;
            this.btnCaptureNow.Click += new System.EventHandler(this.btnCaptureNow_Click);
            // 
            // lblUploadName
            // 
            this.lblUploadName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUploadName.AutoSize = true;
            this.lblUploadName.Location = new System.Drawing.Point(14, 94);
            this.lblUploadName.Name = "lblUploadName";
            this.lblUploadName.Size = new System.Drawing.Size(124, 13);
            this.lblUploadName.TabIndex = 6;
            this.lblUploadName.Text = "Имя файла на сервере";
            this.lblUploadName.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(354, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(345, 178);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основной скриншот";
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pbMainThumb, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMainTime, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 145);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pbMainThumb
            // 
            this.pbMainThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainThumb.Location = new System.Drawing.Point(3, 3);
            this.pbMainThumb.Name = "pbMainThumb";
            this.pbMainThumb.Size = new System.Drawing.Size(319, 114);
            this.pbMainThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainThumb.TabIndex = 0;
            this.pbMainThumb.TabStop = false;
            // 
            // lblMainTime
            // 
            this.lblMainTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainTime.AutoSize = true;
            this.lblMainTime.Location = new System.Drawing.Point(162, 126);
            this.lblMainTime.Name = "lblMainTime";
            this.lblMainTime.Size = new System.Drawing.Size(0, 13);
            this.lblMainTime.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flThumbs);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(354, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 179);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скриншоты";
            // 
            // flThumbs
            // 
            this.flThumbs.AutoScroll = true;
            this.flThumbs.ContextMenuStrip = this.cmsThumbnails;
            this.flThumbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flThumbs.Location = new System.Drawing.Point(3, 16);
            this.flThumbs.Name = "flThumbs";
            this.flThumbs.Size = new System.Drawing.Size(339, 160);
            this.flThumbs.TabIndex = 0;
            // 
            // cmsThumbnails
            // 
            this.cmsThumbnails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьНеотмеченныеToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem});
            this.cmsThumbnails.Name = "cmsThumbnails";
            this.cmsThumbnails.Size = new System.Drawing.Size(204, 48);
            // 
            // удалитьНеотмеченныеToolStripMenuItem
            // 
            this.удалитьНеотмеченныеToolStripMenuItem.Image = global::SOTVVideoUploader.Properties.Resources.Delete;
            this.удалитьНеотмеченныеToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.удалитьНеотмеченныеToolStripMenuItem.Name = "удалитьНеотмеченныеToolStripMenuItem";
            this.удалитьНеотмеченныеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.удалитьНеотмеченныеToolStripMenuItem.Text = "Удалить неотмеченные";
            this.удалитьНеотмеченныеToolStripMenuItem.Click += new System.EventHandler(this.удалитьНеотмеченныеToolStripMenuItem_Click);
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Image = global::SOTVVideoUploader.Properties.Resources.XSDSchema_ClearWorkspaceCmd;
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.очиститьВсеToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(702, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "SOTVVideoUploader";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainThumb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.cmsThumbnails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblCategories;
        private AxWMPLib.AxWindowsMediaPlayer mplayer;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenerateThumbs;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpload;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdOpenMovie;
        private System.Windows.Forms.ToolStripButton btnFileOpen;
        private System.Windows.Forms.ToolStripButton btnGenerateThumbnails;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiAppSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnCaptureNow;
        private System.Windows.Forms.TextBox txtUploadName;
        private System.Windows.Forms.Label lblUploadName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flThumbs;
        private System.Windows.Forms.ToolStripStatusLabel lblThumbsCount;
        private System.Windows.Forms.PictureBox pbMainThumb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMainTime;
        private System.Windows.Forms.ContextMenuStrip cmsThumbnails;
        private System.Windows.Forms.ToolStripMenuItem удалитьНеотмеченныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

