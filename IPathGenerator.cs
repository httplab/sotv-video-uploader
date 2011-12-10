using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    public interface IPathGenerator
    {
        string GetPath(ICategory category, string filename);
    }
}
