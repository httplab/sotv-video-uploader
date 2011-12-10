using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    public interface ICategory
    {
        string Name { get; }
        string Description { get; }
        string Slug { get; }
        DateTime CreatedAt { get; }
        DateTime UpdatedAt { get; }
        int CategoryTypeId { get; }
    }
}
