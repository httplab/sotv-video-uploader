using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOTVVideoUploader
{
    public partial class frmSettingsDialog : Form
    {
        public frmSettingsDialog()
        {
            InitializeComponent();
        }

        public Size LargeThumbnailSize
        {
            get
            {
                return new Size((int) udLThumbW.Value, (int)udLThumbH.Value);
            }
            set
            {
                udLThumbH.Value = value.Height;
                udLThumbW.Value = value.Width;
            }
        }

        public Size SmallThumbnailSize
        {
            get
            {
                return new Size((int)udSThumbW.Value, (int)udSThumbH.Value);
            }
            set
            {
                udSThumbH.Value = value.Height;
                udSThumbW.Value = value.Width;
            }
        }

        public int ThumbnailsNum
        {
            get
            {
                return (int) udThumbsNum.Value;
            }
            set
            {
                udThumbsNum.Value = value;
            }
        }

        public int ThumbnailCaptureStart
        {
            get
            {
                return (int)udThumbsStartTime.Value;
            }
            set
            {
                udThumbsStartTime.Value = value;
            }
        }


        public static void ShowSettings()
        {
            var frm = new frmSettingsDialog();
            frm.LargeThumbnailSize = Properties.Settings.Default.LargeThumbSize; ;
            frm.SmallThumbnailSize = Properties.Settings.Default.SmallThumbSize;

            frm.ThumbnailCaptureStart = Properties.Settings.Default.ThumbsCaptureStart;
            frm.ThumbnailsNum = Properties.Settings.Default.ThumbsNum;
            if (frm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Properties.Settings.Default.LargeThumbSize = frm.LargeThumbnailSize;
            Properties.Settings.Default.SmallThumbSize = frm.SmallThumbnailSize;
            Properties.Settings.Default.ThumbsNum = frm.ThumbnailsNum;
            Properties.Settings.Default.ThumbsCaptureStart = frm.ThumbnailCaptureStart;

            Properties.Settings.Default.Save();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
