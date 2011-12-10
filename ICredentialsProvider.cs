using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    public interface ICredentialsProvider
    {
        string AccessKey { get; }
        string SecretKey { get; }
    }
}
