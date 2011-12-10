using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SOTVVideoUploader
{
    class ConfigCredentialsProvider : ICredentialsProvider
    {
        #region ICredentialsProvider Members

        public string AccessKey
        {
            get { return ConfigurationManager.AppSettings["accessKey"]; }
        }

        public string SecretKey
        {
            get { return ConfigurationManager.AppSettings["secretKey"]; }
        }

        #endregion
    }
}
