using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Image = System.Drawing.Image;
using System.Drawing;

namespace SOTVVideoUploader
{
    public static class ThumbnailAggregator
    {
        public static Image Join(IEnumerable<Thumbnail> thumbs)
        {
            int width = thumbs.Max(t => t.Small.Width);
            int height = thumbs.Sum(t => t.Small.Height);

            Bitmap bmp = new Bitmap(width, height);
            using (var gr = Graphics.FromImage(bmp))
            {
                int y = 0;

                foreach (var thumb in thumbs.OrderBy(t => t.Position))
                {
                    gr.DrawImage(thumb.Small, new Point(0, y));
                    y += thumb.Small.Height;
                }

            }
            return bmp;
        }
    }
}
