using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SOTVVideoUploader
{
    public partial class frmMain : Form
    {
        private string _filename;
        private bool _fileLoaded = false;
        private bool _serverAccessible = false;
        private S3Uploader _uploader = new S3Uploader(new ConfigCredentialsProvider());
        private IThumbnailGenerator _thumbGenerator = new FFMpegThumbnailGenerator();
       
        public frmMain()
        {
            InitializeComponent();
            FillCategoriesCombo();
        }

        public frmMain(string filename)
            :this()
        {
            LoadFile(filename);
        }

        private void LoadFile(string filename)
        {
            _filename = filename;
            mplayer.URL = filename;
            _fileLoaded = true;
            UpdateReadyState();
        }

        public void UpdateReadyState()
        {
            if(_fileLoaded)
            {
                lblFilename.Text = _filename;
            }
            
            lblFilename.Visible = _fileLoaded;
            mplayer.Visible = _fileLoaded;
            lblCategories.Visible = _fileLoaded;
            cmbCategories.Visible = _fileLoaded;
            btnGenerateThumbnails.Enabled = tsmiGenerateThumbs.Enabled = _fileLoaded;
            btnUpload.Enabled = tsmiUpload.Enabled = _serverAccessible && _fileLoaded;
        }

        public void FillCategoriesCombo()
        {
            try
            {
                IEnumerable<ICategory> categories = new CategoryProvider();
                cmbCategories.DataSource = categories.ToList();
                _serverAccessible = true;
            }
            catch
            {
                MessageBox.Show("Невозможно получить список категорий с сервера.", "Получение списка категорий", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategories.Enabled = false;
                _serverAccessible = false;
                UpdateReadyState();
            }
        }

        private void OpenFile()
        {
            if (ofdOpenMovie.ShowDialog() == DialogResult.OK)
            {
                LoadFile(ofdOpenMovie.FileName);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsmiAppSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            frmSettingsDialog.ShowSettings();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            this.Close();
        }

        public ICategory SelectedCategory
        {
            get
            {
                return cmbCategories.SelectedItem as ICategory;
            }
        }

        public void Upload()
        {
            IPathGenerator _generator = new PathGenerator();
            var fileName = Path.GetFileName(_filename);
            mplayer.URL = "";
            mplayer.close();
            _uploader.Upload(_filename, _generator.GetPath(SelectedCategory, fileName));
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void btnGenerateThumbnails_Click(object sender, EventArgs e)
        {
            GenerateThumbs();
        }

        private void GenerateThumbs()
        {
            var thumbs = _thumbGenerator.GetThumbnails(_filename, new ThumbsSettings());
            int i=0;
            foreach (var thumb in thumbs)
            {
                var pb = new PictureBox();
                pb.Width = 100;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.ImageLocation = thumb.LargeThumbPath;
                pb.Left = i* 110;

                splitContainer1.Panel2.Controls.Add(pb);
                i++;
            }
        }
    }
}
