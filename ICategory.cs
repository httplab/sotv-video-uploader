using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    /// <summary>
    /// Категория видео SOTV
    /// </summary>
    public interface ICategory
    {
        /// <summary>
        /// Название категории
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Описание категории
        /// </summary>
        string Description { get; }

        /// <summary>
        /// URL-совместимое название категории
        /// </summary>
        string Slug { get; }
        DateTime CreatedAt { get; }
        DateTime UpdatedAt { get; }
        int CategoryTypeId { get; }
    }
}
