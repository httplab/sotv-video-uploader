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
    /// <summary>
    /// Класс для загрузки данных в S3
    /// </summary>
    public class S3Uploader
    {
        private string _bucketName;
        private AmazonS3Client _client;

        /// <summary>
        /// Создает новый экземпляр класса S3Uploader
        /// </summary>
        /// <param name="credntialsProvider">Провайдер реквизитов для подключения</param>
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

        /// <summary>
        /// Загружает данные из потока на сервер
        /// </summary>
        /// <param name="data">Поток данных</param>
        /// <param name="path">Путь к файлу на сервере</param>
        public void Upload(Stream data, string path)
        {
            try
            {
                var request = new Amazon.S3.Model.PutObjectRequest()
                {
                    BucketName = _bucketName,
                    Key = path,
                    InputStream = data,
                    Timeout = 3600000
                };
                request.AddHeader("x-amz-acl", "public-read");
                _client.PutObject(request);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Не удалось загрузить файл на сервер.", ex);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Загружает файл на сервер
        /// </summary>
        /// <param name="filename">Путь к файлу на диске</param>
        /// <param name="path">Путь к файлу на сервере</param>
        public void Upload(string filename, string path)
        {
            try
            {
                var request = new Amazon.S3.Model.PutObjectRequest()
                {
                    BucketName = _bucketName,
                    Key = path,
                    FilePath = filename,
                    Timeout = 3600000
                };
                request.AddHeader("x-amz-acl", "public-read");
                _client.PutObject(request);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Не удалось загрузить файл на сервер.", ex);
            }
            finally
            {
                
            }
        }
    }
}
