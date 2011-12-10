using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    public class PathGenerator : IPathGenerator
    {
        #region IPathGenerator Members
      
        public string GetPath(ICategory category, string filename)
        {
            return String.Format("{0}/{1}/{2}", category.Slug, DateTime.Now.ToString("yyyy-MM-dd"), filename.Replace(" ", "_"));
        }

        #endregion
    }
}
