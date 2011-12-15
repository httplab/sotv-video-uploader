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
    public partial class frmUploadResult : Form
    {
        public frmUploadResult()
        {
            InitializeComponent();
        }

        public string URL
        {
            get
            {
                return lblUrl.Text;
            }

            set
            {
                lblUrl.Text = value;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(URL);
        }
    }
}
