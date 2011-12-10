using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SOTVVideoUploader
{
    public interface IThumbnailPropertiesProvider
    {
        int Count { get; }
        int CaptureStartTime { get; }
        Size LargeThumbSize { get; }
        Size SmallThumbSize { get; }
    }
}
