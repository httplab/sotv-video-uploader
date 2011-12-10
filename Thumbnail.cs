using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    public class Thumbnail
    {
        public string LargeThumbPath { get; set; }
        public string SmallThumbPath { get; set; }
        public bool IsChecked {get; set;}
        public bool IsMain {get; set;}
    }
}
