﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOTVVideoUploader
{
    public partial class ThumbnailViewer : UserControl
    {
        private Thumbnail _thumbnail;
        public event EventHandler CheckedChanged;


        public ThumbnailViewer()
        {
            InitializeComponent();
        }

        public ThumbnailViewer(Thumbnail thumbnail)
            :this()
        {
            Thumbnail = thumbnail;
        }

        [Browsable(false)]
        public Thumbnail Thumbnail
        {
            get
            {
                return _thumbnail;
            }

            set
            {
                _thumbnail = value;
                pbMain.Image = _thumbnail.Small;
                chbMain.Text = String.Format("{0:00}:{1:00}:{2:00}", _thumbnail.Position.Hours, _thumbnail.Position.Minutes, _thumbnail.Position.Seconds);
                chbMain.Checked = _thumbnail.IsChecked;
            }
        }

        public bool Checked
        {
            get
            {
                return chbMain.Checked;
            }

            set
            {
                chbMain.Checked = value;
            }
        }

        private void chbMain_CheckedChanged(object sender, EventArgs e)
        {
            if (_thumbnail != null)
                _thumbnail.IsChecked = chbMain.Checked;

            if (CheckedChanged != null)
            {
                CheckedChanged(this, new EventArgs());
            }
        }
    }
}