using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Image = System.Drawing.Image;

namespace SOTVVideoUploader
{
    /// <summary>
    /// Скриншот
    /// </summary>
    public class Thumbnail
    {
        /// <summary>
        /// Большой скриншот
        /// </summary>
        public Image Large {get; set;}

        /// <summary>
        /// Малый скриншот
        /// </summary>
        public Image Small {get; set;}

        /// <summary>
        /// Время видеофайла, соответствующее скриншоту
        /// </summary>
        public TimeSpan Position { get; set; }

        /// <summary>
        /// Отмечен ли скриншот для загрузки на сервер
        /// </summary>
        public bool IsChecked { get; set; }

        /// <summary>
        /// Строковое представление времени захвата скриншота
        /// </summary>
        public string Time
        {
            get
            {
                return String.Format("{0:00}:{1:00}:{2:00}", Position.Hours, Position.Minutes, Position.Seconds);
            }
        }
    }
}
