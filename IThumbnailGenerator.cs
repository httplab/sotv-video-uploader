﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    public interface IThumbnailGenerator
    {
        IEnumerable<Thumbnail> GetThumbnails(string filename, IThumbnailPropertiesProvider properties);
    }
}