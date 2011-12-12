using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace SOTVVideoUploader
{
    public class FFMpegThumbnailGenerator : IThumbnailGenerator
    {
        #region IThumbnailGenerator Members

        public IEnumerable<Thumbnail> GetThumbnails(string filename, IThumbnailPropertiesProvider properties)
        {
            var tempPath = Path.GetTempPath();
            
            List<Thumbnail> res = new List<Thumbnail>();
            Random r= new Random();
            FFMpeg ffmpeg = new FFMpeg();

            for (int i = 0; i < properties.Count; i++)
            {
                
                TimeSpan span = new TimeSpan(0, 0, 0, properties.CaptureStartTime, r.Next(0, 60000));
                //var large = ffmpeg.TakeScreenshot(filename, span, properties.LargeThumbSize);
                var small = ffmpeg.TakeScreenshot(filename, span, properties.SmallThumbSize);
                Thumbnail thumb = new Thumbnail()
                {
                    //Large = large,
                    Small = small,
                    Position = span,
                    IsChecked = true,
                };

                res.Add(thumb);
            }

            return res;
        }

        #endregion

        private string GetArgs(string input, int startSectond, Size resolution, string output)
        {
            return String.Format("-i \"{0}\" -ss {1} -s {2}x{3} -vframes 1 {4}", input, startSectond, resolution.Width, resolution.Height, output);
        }
    }
}
