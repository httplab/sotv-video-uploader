using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Configuration;

namespace SOTVVideoUploader
{
    public class CategoryProvider : IEnumerable<ICategory>
    {
        private string _jsonUrl;

        public CategoryProvider()
        {
            _jsonUrl = ConfigurationManager.AppSettings["categoriesURL"];
        }

        public CategoryProvider(string url)
        {
            _jsonUrl = url;
        }

        #region IEnumerable<ICategory> Members

        public IEnumerator<ICategory> GetEnumerator()
        {
            WebRequest request = WebRequest.Create(_jsonUrl);
            var resp = request.GetResponse();
            var stream = resp.GetResponseStream();
            var ser = new DataContractJsonSerializer(typeof(Category[]));
            var res = ser.ReadObject(stream) as Category[];

            for (int i = 0; i < res.Length; i++)
            {
                yield return res[i];
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<ICategory>).GetEnumerator();
        }

        #endregion
    }
}
