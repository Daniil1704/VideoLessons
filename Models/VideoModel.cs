using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoLessons.Models
{
    public class Video
    {
        public int id { get; set; }
        public string title { get; set; } //заголовок
        public string source { get; set; }  //путь к файлу
        public string poster { get; set; } //кто запостил
        public string subtitles { get; set; } //субтитры

        public static List<Video> GetTestData()
        {
            List<Video> videos = new List<Video>();

            videos.Add(new Video()
            {
                title = "Высокое качество",
                poster = "../../images/build.jpg",
                source = "../../video/bentley.mp4"
                //Гипроникель. Обучение пользователей ProjectWise (Часть 1)
            });

            videos.Add(new Video()
            {
                title = "Низкое качество",
                poster = "../../images/build.jpg",
                source = "../../video/bentley.mp4"
            });


            return videos;
        }
    }

}
