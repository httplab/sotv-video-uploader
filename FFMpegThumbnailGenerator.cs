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
        string _pathToffmpegExecutable = "ffmpeg.exe";
        

        #region IThumbnailGenerator Members

        public IEnumerable<Thumbnail> GetThumbnails(string filename, IThumbnailPropertiesProvider properties)
        {
            var tempPath = Path.GetTempPath();
            ProcessStartInfo psi = new ProcessStartInfo(_pathToffmpegExecutable);
            
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            //psi.WorkingDirectory = tempPath;

            List<Thumbnail> res = new List<Thumbnail>();

            for (int i = 1; i < properties.Count; i++)
            {
                string ofTemplate = Path.Combine(tempPath,String.Format("output{0}%d.jpg", i));
                string ofFile = Path.Combine(tempPath,String.Format("output{0}1.jpg", i));
                psi.Arguments = GetArgs(filename, properties.CaptureStartTime, properties.LargeThumbSize, ofTemplate);
                Process pr = new Process();
                pr.StartInfo = psi;
                pr.Start();
                res.Add( new Thumbnail() { LargeThumbPath = Path.Combine(tempPath, ofFile)});
                while (!pr.HasExited) ;
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
