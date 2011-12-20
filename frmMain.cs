using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Encoder = System.Drawing.Imaging.Encoder;
using System.Configuration;
using System.Threading;

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
        private List<Thumbnail> _thumbs=new List<Thumbnail>();
        private Thumbnail _mainThumb;
       
        public frmMain()
        {
            InitializeComponent();
            groupBox1.AllowDrop = true;
            FillCategoriesCombo();
            UpdateReadyState();
        }

        public frmMain(string filename)
            :this()
        {
            LoadFile(filename);
        }

        private void LoadFile(string filename)
        {
            if (_fileLoaded && _thumbs!=null && _thumbs.Any())
            {
                if (MessageBox.Show("При открытии нового файла все текущие скриншоты будут потеряны. Продолжить?", "Открытие файла", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                };
            }

            _filename = filename;
            txtUploadName.Text = Path.GetFileName(_filename);
            txtUploadName.SelectAll();
            mplayer.URL = filename;
            _fileLoaded = true;



            _thumbs = null;
            _mainThumb = null;
            _newThumbs = null;
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
            btnCaptureNow.Enabled = _fileLoaded;
            cmbCategories.Enabled = _fileLoaded;
            lblCategories.Enabled = _fileLoaded;
            lblUploadName.Enabled = _fileLoaded;
            txtUploadName.Enabled = _fileLoaded;
            
            UpdateThumbsPanel();
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
            if (_thumbs == null || !_thumbs.Any(t=>t.IsChecked))
            {
                if (MessageBox.Show("Не выбрано ни одного скриншота. Продолжить загрузку на сервер?","Загрузка на сервер", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }    
            }

            mplayer.URL = "";
            mplayer.close();

            string url;
            Exception ex;
            bool cancel;

            frmLongOperation.PerformAsync<string>(UploadOperation, "Загрузка файлов на сервер", out url, out cancel, out ex, SelectedCategory);

            if (cancel)
            {
                MessageBox.Show("Операция прервана пользователем.", "Загрузка файлов на сервер", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ex != null)
            {
                MessageBox.Show("При загрузке файлов на сервер произошла ошибка.\r\n" + ex.Message, "Загрузка файлов на сервер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = new frmUploadResult();
            frm.URL = url;
            frm.ShowDialog();

            //LongOperationProcessor.PerformLongOperation(UploadOperation, "Загрузка файлов на сервер.",SelectedCategory);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private Thumbnail MainThumb
        {
            get
            {
                return _mainThumb;
            }
            set
            {
                _mainThumb = value;
                if (_mainThumb.Large == null)
                {
                    MakeMainThumb(_mainThumb);
                }

                pbMainThumb.Image = _mainThumb.Large;
                lblMainTime.Text = _mainThumb.Time;
            }
        }

        private string UploadOperation(params object[] args)
        {
           
                IPathGenerator _generator = new PathGenerator();
                var fileName = Path.GetFileName(_filename);
                if (!String.IsNullOrWhiteSpace(txtUploadName.Text))
                {
                    fileName = txtUploadName.Text;
                }


                long quality = 80;

                if (!long.TryParse(ConfigurationManager.AppSettings["jpegQuality"], out quality))
                {
                    quality = 80;
                }


                var encoder = Encoder.Quality;
                var encParams = new EncoderParameters(1);
                var encParam = new EncoderParameter(encoder, quality);
                encParams.Param[0] = encParam;
                var jpegEncoder = GetEncoder(ImageFormat.Jpeg);

                var pathInBucket = _generator.GetPath(args[0] as ICategory, fileName);

                _uploader.Upload(_filename, pathInBucket);


                if (_thumbs.Any(t => t.IsChecked))
                {
                    var img = ThumbnailAggregator.Join(_thumbs.Where(t => t.IsChecked));
                    var stream = new MemoryStream();
                    img.Save(stream, jpegEncoder, encParams);

                    var smallThumbsFilename = fileName + ".small.jpg";

                    _uploader.Upload(stream, _generator.GetPath(args[0] as ICategory, smallThumbsFilename));
                }

                if (_mainThumb != null)
                {
                    var stream = new MemoryStream();
                    var mainThumbFilename = fileName + ".main.jpg";
                    _mainThumb.Large.Save(stream, jpegEncoder, encParams);
                    _uploader.Upload(stream, _generator.GetPath(args[0] as ICategory, mainThumbFilename));
                }

                return ConfigurationManager.AppSettings["urlPrefix"] + pathInBucket;
            
          
        }


        private object UploadThumbsOperation(params object[] args)
        {
            IPathGenerator _generator = new PathGenerator();
            var fileName = Path.GetFileName(_filename);
            if (!String.IsNullOrWhiteSpace(txtUploadName.Text))
            {
                fileName = txtUploadName.Text;
            }


            long quality = 80;

            if (!long.TryParse(ConfigurationManager.AppSettings["jpegQuality"], out quality))
            {
                quality = 80;
            }


            var encoder = Encoder.Quality;
            var encParams = new EncoderParameters(1);
            var encParam = new EncoderParameter(encoder, quality);
            encParams.Param[0] = encParam;
            var jpegEncoder = GetEncoder(ImageFormat.Jpeg);

            var pathInBucket = _generator.GetPath(args[0] as ICategory, fileName);
            if (_thumbs.Any(t => t.IsChecked))
            {
                var img = ThumbnailAggregator.Join(_thumbs.Where(t => t.IsChecked));
                var stream = new MemoryStream();
                img.Save(stream, jpegEncoder, encParams);

                var smallThumbsFilename = fileName + ".small.jpg";

                _uploader.Upload(stream, _generator.GetPath(args[0] as ICategory, smallThumbsFilename));
            }

            if (_mainThumb != null)
            {
                var stream = new MemoryStream();
                var mainThumbFilename = fileName + ".main.jpg";
                _mainThumb.Large.Save(stream, jpegEncoder, encParams);
                _uploader.Upload(stream, _generator.GetPath(args[0] as ICategory, mainThumbFilename));
            }

            return new object() ;


        }

        private void btnGenerateThumbnails_Click(object sender, EventArgs e)
        {
            GenerateThumbs();
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void GenerateThumbs()
        {
            //LongOperationProcessor.PerformLongOperation(GenerateThumbsOperation, "Создание скриншотов");

            object result;
            Exception ex;
            bool cancel;

            frmLongOperation.PerformAsync<object>(GenerateThumbsOperation, "Создание скриншотов", out result, out cancel, out ex);

            if (cancel)
            {
                MessageBox.Show("Операция прервана пользователем.", "Создание скриншотов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ex != null)
            {
                MessageBox.Show("При генерации скриншотов произошла ошибка.\r\n"+ex.Message, "Создание скриншотов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           


            if (_thumbs == null)
            {
                if (_newThumbs == null)
                {
                    _thumbs = new List<Thumbnail>();
                }
                else
                {
                    _thumbs = _newThumbs.ToList();
                }
            }
            else
            {
                if (_newThumbs != null)
                {
                    _thumbs = _thumbs.Where(t => t.IsChecked).Union(_newThumbs).ToList();
                }
            }

            UpdateThumbsPanel();
        }

        private object GenerateThumbsOperation(params object[] args)
        {
            var mediaLength = (int) Math.Floor(mplayer.currentMedia.duration * 1000);
            var checkedCount = _thumbs.Where(t => t.IsChecked).Count();

            var thumbsSettings = new ThumbsSettings();

            if (checkedCount >= thumbsSettings.Count)
                return null;

            _newThumbs = _thumbGenerator.GetThumbnails(_filename,thumbsSettings , thumbsSettings.Count-checkedCount, (int) mediaLength);
            return null;
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCaptureNow_Click(object sender, EventArgs e)
        {
            


            double cpos = mplayer.Ctlcontrols.currentPosition;
            int milliseconds = (int) Math.Round((cpos) * 1000);
            var currentPosition = new TimeSpan(0, 0, 0, 0, milliseconds);

            var thumb = _thumbGenerator.GetThumbnailAt(_filename, currentPosition, new ThumbsSettings());
            _thumbs.Add(thumb);
            UpdateThumbsPanel();
        }

        private void UpdateThumbsPanel()
        {
            flThumbs.SuspendLayout();
            flThumbs.Controls.Clear();

            if (_thumbs == null)
                _thumbs = new List<Thumbnail>();

            if (_thumbs.Any() && _mainThumb==null)
            {
                MainThumb = _thumbs.OrderBy(t=>t.Position).First();
            }

            foreach (var thumb in _thumbs.OrderBy(t => t.Position))
            {
                ThumbnailViewer tv = new ThumbnailViewer(thumb);
                tv.Width = 180;
                tv.Height = 110;
                tv.CheckedChanged += new EventHandler(tv_CheckedChanged);
                tv.MouseDown += new MouseEventHandler(tv_MouseDown);
                flThumbs.Controls.Add(tv);
                
            }

            flThumbs.ResumeLayout();
            flThumbs.PerformLayout();
            tsmiUploadThumbnails.Enabled = _fileLoaded && _thumbs.Any(t => t.IsChecked);

            UpdateThumbsStatus();
        }

        void tv_MouseDown(object sender, MouseEventArgs e)
        {
            var tv = sender as ThumbnailViewer;

            tv.DoDragDrop(tv.Thumbnail, DragDropEffects.Link);
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

     

        private void groupBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Thumbnail)))
            {
                e.Effect = DragDropEffects.Link;
            }   
        }

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {
            var thumb = e.Data.GetData(typeof(Thumbnail)) as Thumbnail;

            if(thumb!=null)
                MainThumb = thumb;
        }

        void MakeMainThumb(Thumbnail thumb)
        {
            _thumbGenerator.GetMainThumb(_filename, thumb, new ThumbsSettings());
        }


        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }

        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            var data = (Array)e.Data.GetData(DataFormats.FileDrop);
            LoadFile(data.GetValue(0).ToString());
        }

        private void удалитьНеотмеченныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thumbs.RemoveAll(t => !t.IsChecked);
            UpdateThumbsPanel();
        }

        private void очиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thumbs = new List<Thumbnail>();
            UpdateThumbsPanel();
        }

        private void tsmiGenerateThumbs_Click(object sender, EventArgs e)
        {
            GenerateThumbs();
        }

        private void tsmiUpload_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsmiUploadThumbnails_Click(object sender, EventArgs e)
        {
            UploadThumbs();
        }

        private void UploadThumbs()
        {
            object res;
            Exception ex;
            bool cancel;

            frmLongOperation.PerformAsync<object>(UploadThumbsOperation, "Загрузка файлов на сервер", out res, out cancel, out ex, SelectedCategory);

            if (cancel)
            {
                MessageBox.Show("Операция прервана пользователем.", "Загрузка файлов на сервер", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ex != null)
            {
                MessageBox.Show("При загрузке файлов на сервер произошла ошибка.\r\n" + ex.Message, "Загрузка файлов на сервер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Загрузка файлов прошла успешно.", "Загрузка файлов на сервер", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
