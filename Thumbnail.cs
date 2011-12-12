using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Image = System.Drawing.Image;

namespace SOTVVideoUploader
{
    public class Thumbnail
    {
        public Image Large {get; set;}
        public Image Small {get; set;}
        public TimeSpan Position { get; set; }

        public bool IsChecked {get; set;}
        public bool IsMain {get; set;}
    }
}
