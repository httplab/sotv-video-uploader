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
    public partial class frmThumbnailPreview : Form
    {
        private Thumbnail _thumb;

        public frmThumbnailPreview()
        {
            InitializeComponent();
        }

        private void frmThumbnailPreview_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        public Thumbnail Thumbnail
        {
            get
            {
                return _thumb;
            }

            set
            {
                _thumb = value;
                pbThumb.Image = _thumb.Large;
                Text = String.Format("Скриншот: {0}", Thumbnail.Time);

                Align();
            }
        }

        private void Align()
        {
            pbThumb.Left = (ClientSize.Width < pbThumb.Width) ? 0 :(ClientSize.Width - pbThumb.Width) / 2;
            pbThumb.Top = (ClientSize.Height < pbThumb.Height) ? 0 :(ClientSize.Height - pbThumb.Height) / 2;
        }

        private void frmThumbnailPreview_Resize(object sender, EventArgs e)
        {
            Align();
        }
    }
}
