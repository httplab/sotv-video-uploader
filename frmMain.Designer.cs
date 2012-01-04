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
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUploadThumbnails = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThumbsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ofdOpenMovie = new System.Windows.Forms.OpenFileDialog();
            this.cmsThumbnails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.mplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUploadName = new System.Windows.Forms.Label();
            this.txtUploadName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flThumbs = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMainTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.cmsThumbnail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnOneFrameBack = new System.Windows.Forms.Button();
            this.btnOneFrameForward = new System.Windows.Forms.Button();
            this.btnCaptureNow = new System.Windows.Forms.Button();
            this.удалитьНеотмеченныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainThumb = new System.Windows.Forms.PictureBox();
            this.btnFileOpen = new System.Windows.Forms.ToolStripButton();
            this.btnGenerateThumbnails = new System.Windows.Forms.ToolStripButton();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.tsmiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenerateThumbs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteThumb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMakeMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteUnchecked1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tltBtns = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cmsThumbnails.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsThumbnail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainThumb)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
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
            this.tsmiUpload,
            this.tsmiUploadThumbnails});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // tsmiUploadThumbnails
            // 
            this.tsmiUploadThumbnails.Enabled = false;
            this.tsmiUploadThumbnails.Name = "tsmiUploadThumbnails";
            this.tsmiUploadThumbnails.Size = new System.Drawing.Size(266, 22);
            this.tsmiUploadThumbnails.Text = "Загрузить скриншоты на сервер";
            this.tsmiUploadThumbnails.Click += new System.EventHandler(this.tsmiUploadThumbnails_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAppSettings});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
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
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ofdOpenMovie
            // 
            this.ofdOpenMovie.Filter = "Видеофайлы|*.mov;*.mp4|Все файлы|*.*";
            this.ofdOpenMovie.Title = "Выберите файл";
            // 
            // cmsThumbnails
            // 
            this.cmsThumbnails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьНеотмеченныеToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem});
            this.cmsThumbnails.Name = "cmsThumbnails";
            this.cmsThumbnails.Size = new System.Drawing.Size(204, 48);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFilename, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(760, 448);
            this.tableLayoutPanel3.TabIndex = 7;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel5);
            this.splitContainer1.Size = new System.Drawing.Size(754, 417);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.mplayer, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(401, 417);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // mplayer
            // 
            this.mplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mplayer.Enabled = true;
            this.mplayer.Location = new System.Drawing.Point(20, 3);
            this.mplayer.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.mplayer.Name = "mplayer";
            this.mplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mplayer.OcxState")));
            this.mplayer.Size = new System.Drawing.Size(361, 314);
            this.mplayer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOneFrameBack);
            this.panel1.Controls.Add(this.btnOneFrameForward);
            this.panel1.Controls.Add(this.lblUploadName);
            this.panel1.Controls.Add(this.btnCaptureNow);
            this.panel1.Controls.Add(this.txtUploadName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 91);
            this.panel1.TabIndex = 2;
            // 
            // lblUploadName
            // 
            this.lblUploadName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUploadName.AutoSize = true;
            this.lblUploadName.Location = new System.Drawing.Point(14, 52);
            this.lblUploadName.Name = "lblUploadName";
            this.lblUploadName.Size = new System.Drawing.Size(124, 13);
            this.lblUploadName.TabIndex = 16;
            this.lblUploadName.Text = "Имя файла на сервере";
            // 
            // txtUploadName
            // 
            this.txtUploadName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUploadName.Location = new System.Drawing.Point(17, 68);
            this.txtUploadName.Name = "txtUploadName";
            this.txtUploadName.Size = new System.Drawing.Size(361, 20);
            this.txtUploadName.TabIndex = 17;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(343, 417);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flThumbs);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 187);
            this.groupBox2.TabIndex = 11;
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
            this.flThumbs.Size = new System.Drawing.Size(331, 168);
            this.flThumbs.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(337, 186);
            this.groupBox1.TabIndex = 10;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(317, 153);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblMainTime
            // 
            this.lblMainTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainTime.AutoSize = true;
            this.lblMainTime.Location = new System.Drawing.Point(158, 134);
            this.lblMainTime.Name = "lblMainTime";
            this.lblMainTime.Size = new System.Drawing.Size(0, 13);
            this.lblMainTime.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCategories);
            this.panel2.Controls.Add(this.lblCategories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 26);
            this.panel2.TabIndex = 12;
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(73, 0);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(261, 21);
            this.cmbCategories.TabIndex = 13;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(10, 3);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(60, 13);
            this.lblCategories.TabIndex = 14;
            this.lblCategories.Text = "Категория";
            // 
            // lblFilename
            // 
            this.lblFilename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(20, 6);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(0, 13);
            this.lblFilename.TabIndex = 1;
            // 
            // cmsThumbnail
            // 
            this.cmsThumbnail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteThumb,
            this.tsmiMakeMain,
            this.tsmiPreview,
            this.tsmiDeleteUnchecked1,
            this.tsmiDeleteAll1});
            this.cmsThumbnail.Name = "cmsThumbnail";
            this.cmsThumbnail.Size = new System.Drawing.Size(204, 114);
            // 
            // btnOneFrameBack
            // 
            this.btnOneFrameBack.Enabled = false;
            this.btnOneFrameBack.Image = global::SOTVVideoUploader.Properties.Resources.Back;
            this.btnOneFrameBack.Location = new System.Drawing.Point(17, 7);
            this.btnOneFrameBack.Name = "btnOneFrameBack";
            this.btnOneFrameBack.Size = new System.Drawing.Size(75, 30);
            this.btnOneFrameBack.TabIndex = 19;
            this.btnOneFrameBack.Text = "Назад";
            this.btnOneFrameBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tltBtns.SetToolTip(this.btnOneFrameBack, "Назад на один кадр");
            this.btnOneFrameBack.UseVisualStyleBackColor = true;
            this.btnOneFrameBack.Click += new System.EventHandler(this.btnOneFrameBack_Click);
            // 
            // btnOneFrameForward
            // 
            this.btnOneFrameForward.Enabled = false;
            this.btnOneFrameForward.Image = global::SOTVVideoUploader.Properties.Resources.forward;
            this.btnOneFrameForward.Location = new System.Drawing.Point(303, 7);
            this.btnOneFrameForward.Name = "btnOneFrameForward";
            this.btnOneFrameForward.Size = new System.Drawing.Size(75, 30);
            this.btnOneFrameForward.TabIndex = 18;
            this.btnOneFrameForward.Text = "Вперед";
            this.btnOneFrameForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tltBtns.SetToolTip(this.btnOneFrameForward, "Вперед на один кадр");
            this.btnOneFrameForward.UseVisualStyleBackColor = true;
            this.btnOneFrameForward.Click += new System.EventHandler(this.btnOneFrameForward_Click);
            // 
            // btnCaptureNow
            // 
            this.btnCaptureNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptureNow.Image = global::SOTVVideoUploader.Properties.Resources.GenVideoDoc_16x16_72;
            this.btnCaptureNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaptureNow.Location = new System.Drawing.Point(143, 3);
            this.btnCaptureNow.Name = "btnCaptureNow";
            this.btnCaptureNow.Size = new System.Drawing.Size(99, 38);
            this.btnCaptureNow.TabIndex = 15;
            this.btnCaptureNow.Text = "Сделать скриншот";
            this.btnCaptureNow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaptureNow.UseVisualStyleBackColor = true;
            this.btnCaptureNow.Click += new System.EventHandler(this.btnCaptureNow_Click);
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
            // pbMainThumb
            // 
            this.pbMainThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainThumb.Location = new System.Drawing.Point(3, 3);
            this.pbMainThumb.Name = "pbMainThumb";
            this.pbMainThumb.Size = new System.Drawing.Size(311, 122);
            this.pbMainThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainThumb.TabIndex = 0;
            this.pbMainThumb.TabStop = false;
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileOpen.Image = global::SOTVVideoUploader.Properties.Resources.openHS;
            this.btnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(23, 22);
            this.btnFileOpen.Text = "Открыть файл";
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
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
            // tsmiFileOpen
            // 
            this.tsmiFileOpen.Image = global::SOTVVideoUploader.Properties.Resources.openHS;
            this.tsmiFileOpen.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsmiFileOpen.Name = "tsmiFileOpen";
            this.tsmiFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiFileOpen.Size = new System.Drawing.Size(164, 22);
            this.tsmiFileOpen.Text = "Открыть";
            this.tsmiFileOpen.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
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
            // tsmiAppSettings
            // 
            this.tsmiAppSettings.Image = global::SOTVVideoUploader.Properties.Resources.settings_16;
            this.tsmiAppSettings.Name = "tsmiAppSettings";
            this.tsmiAppSettings.Size = new System.Drawing.Size(207, 22);
            this.tsmiAppSettings.Text = "Настройки приложения";
            this.tsmiAppSettings.Click += new System.EventHandler(this.tsmiAppSettings_Click);
            // 
            // tsmiDeleteThumb
            // 
            this.tsmiDeleteThumb.Image = global::SOTVVideoUploader.Properties.Resources.Delete;
            this.tsmiDeleteThumb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDeleteThumb.Name = "tsmiDeleteThumb";
            this.tsmiDeleteThumb.Size = new System.Drawing.Size(203, 22);
            this.tsmiDeleteThumb.Text = "Удалить";
            this.tsmiDeleteThumb.Click += new System.EventHandler(this.tsmiDeleteThumb_Click);
            // 
            // tsmiMakeMain
            // 
            this.tsmiMakeMain.Image = global::SOTVVideoUploader.Properties.Resources.base_checkmark_32;
            this.tsmiMakeMain.Name = "tsmiMakeMain";
            this.tsmiMakeMain.Size = new System.Drawing.Size(203, 22);
            this.tsmiMakeMain.Text = "Сделать основным";
            this.tsmiMakeMain.Click += new System.EventHandler(this.tsmiMakeMain_Click);
            // 
            // tsmiPreview
            // 
            this.tsmiPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiPreview.Image = global::SOTVVideoUploader.Properties.Resources.PrintPreviewHS;
            this.tsmiPreview.Name = "tsmiPreview";
            this.tsmiPreview.Size = new System.Drawing.Size(203, 22);
            this.tsmiPreview.Text = "Просмотр";
            this.tsmiPreview.Click += new System.EventHandler(this.tsmiPreview_Click);
            // 
            // tsmiDeleteUnchecked1
            // 
            this.tsmiDeleteUnchecked1.Image = global::SOTVVideoUploader.Properties.Resources.Delete;
            this.tsmiDeleteUnchecked1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDeleteUnchecked1.Name = "tsmiDeleteUnchecked1";
            this.tsmiDeleteUnchecked1.Size = new System.Drawing.Size(203, 22);
            this.tsmiDeleteUnchecked1.Text = "Удалить неотмеченные";
            this.tsmiDeleteUnchecked1.Click += new System.EventHandler(this.удалитьНеотмеченныеToolStripMenuItem_Click);
            // 
            // tsmiDeleteAll1
            // 
            this.tsmiDeleteAll1.Image = global::SOTVVideoUploader.Properties.Resources.XSDSchema_ClearWorkspaceCmd;
            this.tsmiDeleteAll1.Name = "tsmiDeleteAll1";
            this.tsmiDeleteAll1.Size = new System.Drawing.Size(203, 22);
            this.tsmiDeleteAll1.Text = "Очистить все";
            this.tsmiDeleteAll1.Click += new System.EventHandler(this.очиститьВсеToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(760, 519);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SOTVVideoUploader.Properties.Settings.Default, "frmLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::SOTVVideoUploader.Properties.Settings.Default.frmLocation;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(776, 557);
            this.Name = "frmMain";
            this.Text = "SOTVVideoUploader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsThumbnails.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cmsThumbnail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
        private System.Windows.Forms.ToolStripStatusLabel lblThumbsCount;
        private System.Windows.Forms.ContextMenuStrip cmsThumbnails;
        private System.Windows.Forms.ToolStripMenuItem удалитьНеотмеченныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private AxWMPLib.AxWindowsMediaPlayer mplayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblUploadName;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Button btnCaptureNow;
        private System.Windows.Forms.TextBox txtUploadName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flThumbs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbMainThumb;
        private System.Windows.Forms.Label lblMainTime;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.ToolStripMenuItem tsmiUploadThumbnails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cmsThumbnail;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteThumb;
        private System.Windows.Forms.ToolStripMenuItem tsmiMakeMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreview;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteUnchecked1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAll1;
        private System.Windows.Forms.Button btnOneFrameBack;
        private System.Windows.Forms.Button btnOneFrameForward;
        private System.Windows.Forms.ToolTip tltBtns;
    }
}

