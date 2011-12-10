using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    [Serializable]
    public class Category : ICategory
    {
        private string name;
        private string description;
        private string slug;
        private string created_at;
        private string updated_at;
        private int tv_show_category_type_id;

        private Category()
        {
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public int CategoryTypeId
        {
            get
            {
                return tv_show_category_type_id;
            }
        }

        public string Slug
        {
            get
            {
                return slug;
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return DateTime.Parse(created_at);
            }
        }

        public DateTime UpdatedAt
        {
            get
            {
                return DateTime.Parse(updated_at);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
