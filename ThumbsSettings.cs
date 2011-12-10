using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SOTVVideoUploader
{
    public class ThumbsSettings : IThumbnailPropertiesProvider
    {
        #region IThumbnailPropertiesProvider Members

        public int Count
        {
            get { return Properties.Settings.Default.ThumbsNum; }
        }

        public int CaptureStartTime
        {
            get { return Properties.Settings.Default.ThumbsCaptureStart; }
        }

        public System.Drawing.Size LargeThumbSize
        {
            get { return Properties.Settings.Default.LargeThumbSize; }
        }

        public System.Drawing.Size SmallThumbSize
        {
            get { return Properties.Settings.Default.SmallThumbSize; }
        }

        #endregion
    }
}
