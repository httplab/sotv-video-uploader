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
    public partial class frmLongOperation : Form
    {
        public frmLongOperation()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return lblMessage.Text;
            }

            set
            {
                lblMessage.Text = value;
            }
        }
    }
}
