using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.S3;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace SOTVVideoUploader
{
    public class S3Uploader
    {
        private AWSCredentials _credentials;
        private string _bucketName;
        private AmazonS3Client _client;

        public S3Uploader(ICredentialsProvider credntialsProvider)
        {
            AmazonS3Config config = new
            AmazonS3Config()
            {
                CommunicationProtocol = Amazon.S3.Model.Protocol.HTTPS,
                BufferSize = 1024*1024,
            };
            var _credentials = new BasicAWSCredentials("AKIAJN2R2DUUOVRZR66Q", "9r9l4q5xW7vZhfs+BT8ky1RpQYj8lRZr9k9ha1VY");
            _bucketName = ConfigurationManager.AppSettings["bucketName"];
            _client = new AmazonS3Client(_credentials,config);
            
        }

        public void Upload(string filename, string path)
        {
            try
            {
                var request = new Amazon.S3.Model.PutObjectRequest()
                {
                    BucketName = _bucketName,
                    Key = path,
                    FilePath = filename, 
                };
                request.AddHeader("x-amz-acl", "public-read");
                _client.BeginPutObject(request, Callback, null);
            }
            catch
            {
                throw new ApplicationException("Не удалось загрузить файл на сервер.");
            }
            finally
            {
                
            }
        }

        private void Callback(IAsyncResult result)
        {
            try
            {
                _client.EndPutObject(result);
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }
    }
}
