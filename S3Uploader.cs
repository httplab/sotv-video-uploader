using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.S3;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace SOTVVideoUploader
{
    /// <summary>
    /// Класс для загрузки данных в S3
    /// </summary>
    public class S3Uploader
    {
        private string _bucketName;
        private AmazonS3Client _client;
        private int _timeout = 3600000;

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
            var _credentials = new BasicAWSCredentials(credntialsProvider.AccessKey, credntialsProvider.SecretKey);
            _bucketName = ConfigurationManager.AppSettings["bucketName"];
            _client = new AmazonS3Client(_credentials,config);

            var strTimeout = ConfigurationManager.AppSettings["amazonRequestTimeout"];
            int minutesTimeout;
            if (int.TryParse(strTimeout, out minutesTimeout))
            {
                _timeout = minutesTimeout * 60 * 1000;
            }
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
                    Timeout = _timeout,
                };
                request.AddHeader("x-amz-acl", "public-read");
                _client.PutObject(request);
            }
            catch (ThreadAbortException tae)
            {

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
                    Timeout = _timeout,
                };
                request.AddHeader("x-amz-acl", "public-read");
                _client.PutObject(request);
            }
            catch (ThreadAbortException tae)
            {

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
