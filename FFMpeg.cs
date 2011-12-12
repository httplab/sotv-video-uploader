using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.EC2.Model;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using Image = System.Drawing.Image;

namespace SOTVVideoUploader
{
    /// <summary>
    /// Обертка для ffmpeg
    /// </summary>
    public class FFMpeg
    {
        private string _pathToffmpegExecutable = "ffmpeg";

        private void Execute(string args, bool waitProcessToStop)
        {
            ProcessStartInfo psi = new ProcessStartInfo(_pathToffmpegExecutable);
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Arguments = args;
            Process pr = new Process();
            pr.StartInfo = psi;
            pr.Start();

            if(waitProcessToStop)
                while (!pr.HasExited) ;
        }

        /// <summary>
        /// Делает скриншот из указанного файла
        /// </summary>
        /// <param name="filename">Путь к видеофайлу</param>
        /// <param name="position">Время скриншота</param>
        /// <param name="resolution">Разрешение скринщота</param>
        /// <returns>Изображение со скриншотом</returns>
        public Image TakeScreenshot(string filename, TimeSpan position, Size resolution)
        {
            var output = Path.GetTempFileName();

            string arguments = String.Format("-ss {1}:{2}:{3}.{4} -i \"{0}\" -vframes 1 -f image2 -s {5}x{6} \"{7}\"",
                filename,
                position.Hours,
                position.Minutes,
                position.Seconds,
                position.Milliseconds,
                resolution.Width,
                resolution.Height,
                output
                );

            Execute(arguments, true);

            var img =  Image.FromFile(output);
            try
            {
                if (File.Exists(output))
                {
                    File.Delete(output);
                }
            }
            catch
            {
            }

            return img;
        }
    }
}
