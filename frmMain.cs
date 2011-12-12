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
        private const string _title = "SOTVVideoUploader";
        private string _filename;
        private bool _fileLoaded = false;
        private bool _serverAccessible = false;
        private S3Uploader _uploader = new S3Uploader(new ConfigCredentialsProvider());
        private IThumbnailGenerator _thumbGenerator = new FFMpegThumbnailGenerator();
        private IEnumerable<Thumbnail> _newThumbs;
        private List<Thumbnail> _thumbs;
        private Thumbnail _mainThumb;
       
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
                Text = String.Format("{0} - {1}", _title, Path.GetFileName(_filename));
            }
            
            
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
            
            mplayer.URL = "";
            mplayer.close();
            LongOperationProcessor.PerformLongOperation(UploadOperation, "Загрузка файлов на сервер.",SelectedCategory);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void UploadOperation(params object[] args)
        {
            IPathGenerator _generator = new PathGenerator();
            var fileName = Path.GetFileName(_filename);
            _uploader.Upload(_filename, _generator.GetPath(args[0] as ICategory, fileName));
            var img = ThumbnailAggregator.Join(_thumbs.Where(t => t.IsChecked));
            var stream = new MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            var smallThumbsFilename = fileName + ".small.jpg";

            _uploader.Upload(stream, _generator.GetPath(args[0] as ICategory, smallThumbsFilename));
        }

        private void btnGenerateThumbnails_Click(object sender, EventArgs e)
        {
            GenerateThumbs();
        }

        private void GenerateThumbs()
        {
            
            LongOperationProcessor.PerformLongOperation(GenerateThumbsOperation, "Идет генерация скриншотов");
            _thumbs = _newThumbs.ToList();
            UpdateThumbsPanel();
        }

        private void GenerateThumbsOperation(params object[] args)
        {
            _newThumbs = _thumbGenerator.GetThumbnails(_filename, new ThumbsSettings());
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCaptureNow_Click(object sender, EventArgs e)
        {

        }

        private void UpdateThumbsPanel()
        {
            flThumbs.SuspendLayout();
            flThumbs.Controls.Clear();

            foreach (var thumb in _thumbs.OrderBy(t => t.Position))
            {
                ThumbnailViewer tv = new ThumbnailViewer(thumb);
                tv.Width = thumb.Small.Width + 6;
                tv.Height = thumb.Small.Height + 20;
                tv.CheckedChanged += new EventHandler(tv_CheckedChanged);
                flThumbs.Controls.Add(tv);
                
            }

            flThumbs.ResumeLayout();
            UpdateThumbsStatus();
        }

        void tv_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThumbsStatus();
        }

        void UpdateThumbsStatus()
        {
            lblThumbsCount.Text =
                String.Format("Выбрано {0} скриншотов из {1}", _thumbs.Where(t => t.IsChecked).Count(), _thumbs.Count);
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var thumb = e.Data.GetData(typeof(Thumbnail)) as Thumbnail;
            _mainThumb = thumb;
            pictureBox1.Image = _mainThumb.Large;
        }
    }
}
