using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;
using System.Text;

using LibVLCSharp.Shared;

namespace VideoLessons.Models
{
    public class Lessons
    {
        [ScaffoldColumn(false)]
        public int ID
        {
            get; set;
        }

        public int ID_sort
        {
            get; set;
        }

        //тип лекции - например, "Курс ProjectWise. Администраторы."
        [Required]
        [Display(Name = "Тип лекции")]
        public string Title
        {
            get; set;
        }

        //описание для идентификации - например, "День 1, Часть 1"
        [Required]
        [Display(Name = "Описание")]
        public string Description
        {
            get; set;
        }

        //длительность - "13:00"
        [Required]
        [Display(Name = "Длительность")]
        public string Timeline
        {
            get; set;
        }

        [Required]
        [Display(Name = "Ссылка")]
        public string Link
        {
            get; set;
        }

        [Required]
        [Display(Name = "Инструктор")]
        public string Creator
        {
            get; set;
        }

        [Display(Name = "Оценка")]
        public int Rating
        {
            get; set;
        }

        [Display(Name = "Переходы")]
        [DataType("Integer")]
        public int Moving
        {
            get; set;
        }

        public string source { get; set; }  //путь к файлу
        public string poster { get; set; }  //картинка

        //субтитры
        public virtual ICollection<String> Subtitles { get; set; }
        public virtual ICollection<String> JsTimings { get; set; }

        public static List<Lessons> cashdata = new List<Lessons>();

        public static List<Lessons> GetRealData(string path)
        {
            List<Lessons> result = new List<Lessons>();
            int counter = -1;
            var rand = new Random();

            #region "Администраторы ProjectWise"

            int ID_step = 2;
            string title_name = "02) Обучение администраторов ProjectWise";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение Администраторов ProjectWise (День 1, Часть 1).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "1:29:10",
                Subtitles = SubtitlesTemplateModel.sub11.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub11.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение Администраторов ProjectWise (День 1, Часть 2).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:14:59",
                Subtitles = SubtitlesTemplateModel.sub12.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub12.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 3",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение Администраторов ProjectWise (День 1, Часть 3).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "1:12:31",
                Subtitles = SubtitlesTemplateModel.sub13.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub13.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 4",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение Администраторов ProjectWise (День 1, Часть 4).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "1:13:29",
                Subtitles = SubtitlesTemplateModel.sub14.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub14.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение Администраторов ProjectWise (День 2, Часть 1).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "1:31:25",
                Subtitles = SubtitlesTemplateModel.sub15.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub15.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение Администраторов ProjectWise (День 2, Часть 2).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:03:22",
                Subtitles = SubtitlesTemplateModel.sub16.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub16.Split("\r\n").ToList())
            });

            #endregion

            #region "Пользователи ProjectWise"

            ID_step = 1;
            title_name = "01) Обучение пользователей ProjectWise";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение пользователей ProjectWise (Часть 1).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "4:00:00",
                Subtitles = SubtitlesTemplateModel.sub1.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub1.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение пользователей ProjectWise (Часть 2).mp4",
                Creator = "Штурцев Владимир",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:35:55",
                Subtitles = SubtitlesTemplateModel.sub2.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub2.Split("\r\n").ToList())
            });

            #endregion

            #region "Администраторы Microstation"

            ID_step = 4;
            title_name = "04) Обучение администраторов Microstation";
            
            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 1_1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:03:29",
                Subtitles = SubtitlesTemplateModel.sub21.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub21.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 1_2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:23:41",
                Subtitles = SubtitlesTemplateModel.sub22.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub22.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 2_1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:53:33",
                Subtitles = SubtitlesTemplateModel.sub23.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub23.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 2_2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:35:12",
                Subtitles = SubtitlesTemplateModel.sub24.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub24.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 3_1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:40:14",
                Subtitles = SubtitlesTemplateModel.sub25.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub25.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 3_2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:35:36",
                Subtitles = SubtitlesTemplateModel.sub26.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub26.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 4, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 4_1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:35:36",
                Subtitles = SubtitlesTemplateModel.sub27.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub27.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 4, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 4_2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "0:25:36",
                Subtitles = SubtitlesTemplateModel.sub28.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub28.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 4, Часть 3",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation. Администраторы. День 4_3.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "1:14:41",
                Subtitles = SubtitlesTemplateModel.sub29.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub29.Split("\r\n").ToList())
            });

            #endregion

            #region "Promise"

            ID_step = 5;
            title_name = "05) Обучение пользователей Promise";

            for (int i = 1; i < 5; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 1, Часть " + i,
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/PromisE - урок 1." + i + ".mp4",
                    Creator = "Иванов Сергей",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "PromisE - урок 1." + i + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 1." + i + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 1." + i + ".txt").Split("\r\n").ToList())
                });
            }

            for (int i = 1; i < 3; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 2, Часть " + i,
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/PromisE - урок 2." + i + ".mp4",
                    Creator = "Иванов Сергей",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "PromisE - урок 2." + i + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 2." + i + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 2." + i + ".txt").Split("\r\n").ToList())
                });
            }

            for (int i = 1; i < 3; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 3, Часть " + i,
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/PromisE - урок 3." + i + ".mp4",
                    Creator = "Иванов Сергей",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "PromisE - урок 3." + i + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 3." + i + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 3." + i + ".txt").Split("\r\n").ToList())
                });
            }


            for (int i = 1; i < 6; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 4, Часть " + i,
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/PromisE - урок 4." + i + ".mp4",
                    Creator = "Иванов Сергей",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "PromisE - урок 4." + i + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 4." + i + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 4." + i + ".txt").Split("\r\n").ToList())
                });
            }

            for (int i = 1; i < 4; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 5, Часть " + i,
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/PromisE - урок 5." + i + ".mp4",
                    Creator = "Иванов Сергей",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "PromisE - урок 5." + i + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 5." + i + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Promise - урок 5." + i + ".txt").Split("\r\n").ToList())
                });
            }

            #endregion

            #region "BRCM"

            ID_step = 9;
            title_name = "09) Обучение пользователей BRCM";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 1.1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:20:29",
                Subtitles = SubtitlesTemplateModel.sub31.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub31.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 1.2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:40:02",
                Subtitles = SubtitlesTemplateModel.sub32.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub32.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 2.1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:10:57",
                Subtitles = SubtitlesTemplateModel.sub33.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub33.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 2.2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:20:25",
                Subtitles = SubtitlesTemplateModel.sub34.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub34.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 3.1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:36:46",
                Subtitles = SubtitlesTemplateModel.sub35.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub35.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 3.2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:52:00",
                Subtitles = SubtitlesTemplateModel.sub36.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub36.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 4, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 4.1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:35:38",
                Subtitles = SubtitlesTemplateModel.sub37.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub37.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 4, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение BRCM 4.2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "1:30:51",
                Subtitles = SubtitlesTemplateModel.sub38.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub38.Split("\r\n").ToList())
            });

            #endregion

            #region "Пользователи Microstation"

            ID_step = 3;
            title_name = "03) Обучение пользователей Microstation";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation 1.1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:29:25",
                Subtitles = SubtitlesTemplateModel.sub41.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub41.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation 1.2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:54:06",
                Subtitles = SubtitlesTemplateModel.sub42.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub42.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation 2.1.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:49:27",
                Subtitles = SubtitlesTemplateModel.sub43.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub43.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation 2.2.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "0:40:59",
                Subtitles = SubtitlesTemplateModel.sub44.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub44.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 3",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение MicroStation 2.3.mp4",
                Creator = "Бородин Денис",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:02:38",
                Subtitles = SubtitlesTemplateModel.sub45.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.sub45.Split("\r\n").ToList())
            });

            #endregion

            #region "ProConcrete"

            ID_step = 8;
            title_name = "08) Обучение пользователей ProConcrete";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProConcrete День 1 часть 1.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:49:13",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 6.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 6.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProConcrete День 1 часть 2.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:59:45",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 6.2.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 6.2.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProConcrete День 2 часть 1.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:48:12",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 7.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 7.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProConcrete День 2 часть 2.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:17:21",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 7.2.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 7.2.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProConcrete День 3 часть 1.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:35:24",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 8.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 8.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProConcrete День 3 часть 2.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:18:48",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 8.2.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 8.2.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3, Часть 3",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProConcrete День 3 часть 3.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "0:10:27",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 8.3.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProConcrete - урок 8.3.txt").Split("\r\n").ToList())
            });

            #endregion

            #region "ProSteel"

            ID_step = 7;
            title_name = "07) Обучение пользователей ProSteel";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 1 часть 1.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline =  "3:47:21",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 1.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 1.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 1 часть 2.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:21:45",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 1.2.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 1.2.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 3",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 1 часть 3.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "0:06:06",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 1.3.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 1.3.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 2 часть 1.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:50:36",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 2.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 2.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 2, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 2 часть 2.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:13:22",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 2.2.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 2.2.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 3",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 3.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "6:18:25",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 3.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 3.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 4",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 4.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "6:26:27",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 4.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 4.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 5, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 5 часть 1.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:07:27",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 5.1.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 5.1.txt").Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 5, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/ProSteel День 5 часть 2.mp4",
                Creator = "Янулявичюс Робертас",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:55:24",
                Subtitles = SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 5.2.txt").Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "ProSteel - урок 5.2.txt").Split("\r\n").ToList())
            });

            #endregion

            #region "OpenRoads"

            ID_step = 10;
            title_name = "10) Обучение пользователей OpenRoads";

            for (int i = 1; i < 5; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 1, Часть " + i.ToString(),
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/Обучение OpenRoads Designer 21 №" + i.ToString() + ".mp4",
                    Creator = "Витушкин Олег",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "Обучение OpenRoads Designer 21 №" + i.ToString() + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 1 часть " + i.ToString() + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 1 часть " + i.ToString() + ".txt").Split("\r\n").ToList())
                });
            }

            for (int i = 1; i < 5; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 2, Часть " + i.ToString(),
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/Обучение OpenRoads Designer 22 №" + i.ToString() + ".mp4",
                    Creator = "Витушкин Олег",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "Обучение OpenRoads Designer 22 №" + i.ToString() + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 2 часть " + i.ToString() + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 2 часть " + i.ToString() + ".txt").Split("\r\n").ToList())
                });
            }

            for (int i = 1; i < 4; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 3, Часть " + i.ToString(),
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/Обучение OpenRoads Designer 23 №" + i.ToString() + ".mp4",
                    Creator = "Витушкин Олег",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "Обучение OpenRoads Designer 23 №" + i.ToString() + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 3 часть " + i.ToString() + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 3 часть " + i.ToString() + ".txt").Split("\r\n").ToList())
                });
            }

            for (int i = 1; i < 5; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 4, Часть " + i.ToString(),
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/Обучение OpenRoads Designer 24 №" + i.ToString() + ".mp4",
                    Creator = "Витушкин Олег",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "Обучение OpenRoads Designer 24 №" + i.ToString() + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 4 часть " + i.ToString() + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 4 часть " + i.ToString() + ".txt").Split("\r\n").ToList())
                });
            }

            for (int i = 1; i < 5; i++)
            {
                result.Add(new Lessons()
                {
                    ID = ++counter,
                    ID_sort = ID_step,
                    Title = title_name,
                    Description = "День 5, Часть " + i.ToString(),
                    Link = "Home/Video/",
                    poster = "../../images/build.jpg",
                    source = "../../video/Обучение OpenRoads Designer 25 №" + i.ToString() + ".mp4",
                    Creator = "Витушкин Олег",
                    Moving = rand.Next(1, 10),
                    Rating = 5,
                    Timeline = SubtitlesTemplateModel.convertMsToHMmSs(path, "Обучение OpenRoads Designer 25 №" + i.ToString() + ".mp4"),
                    Subtitles = SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 5 часть " + i.ToString() + ".txt").Split("\r\n").ToList(),
                    JsTimings = GetMillis(SubtitlesTemplateModel.GetFromFile(path, "Обучение ORD день 5 часть " + i.ToString() + ".txt").Split("\r\n").ToList())
                });
            }

            #endregion

            #region "ContextCapture"

            ID_step = 11;
            title_name = "11) Обучение пользователей ContextCapture";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение Bentley ContextCapture 13.10 №1.mp4",
                Creator = "Антон Ахметов",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "2:21:00",
                Subtitles = SubtitlesTemplateModel.nosub.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.nosub.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Обучение Bentley ContextCapture 13.10 №2.mp4",
                Creator = "Антон Ахметов",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "0:35:15",
                Subtitles = SubtitlesTemplateModel.nosub.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.nosub.Split("\r\n").ToList())
            });

            #endregion

            #region "OpenPlant Modeler"

            ID_step = 13;
            title_name = "13) Обучение пользователей OpenPlant Modeler";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Bentley OpenPlant-20201019_090025-Meeting Recording.mp4",
                Creator = "Найденов Сергей",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:32:30",
                Subtitles = SubtitlesTemplateModel.nosub.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.nosub.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Bentley OpenPlant-20201019_153003-Meeting Recording.mp4",
                Creator = "Найденов Сергей",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "1:30:24",
                Subtitles = SubtitlesTemplateModel.nosub.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.nosub.Split("\r\n").ToList())
            });

            #endregion

            #region "OpenPlant PID"

            ID_step = 14;
            title_name = "14) Обучение пользователей OpenPlant PID";

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Bentley OpenPlant-20201019_090025-Meeting Recording.mp4",
                Creator = "Найденов Сергей",
                Moving = rand.Next(1, 20),
                Rating = 5,
                Timeline = "3:32:30",
                Subtitles = SubtitlesTemplateModel.nosub.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.nosub.Split("\r\n").ToList())
            });

            result.Add(new Lessons()
            {
                ID = ++counter,
                ID_sort = ID_step,
                Title = title_name,
                Description = "День 1, Часть 2",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Bentley OpenPlant-20201016_133008-Meeting Recording.mp4",
                Creator = "Найденов Сергей",
                Moving = rand.Next(1, 10),
                Rating = 5,
                Timeline = "3:23:04",
                Subtitles = SubtitlesTemplateModel.nosub.Split("\r\n").ToList(),
                JsTimings = GetMillis(SubtitlesTemplateModel.nosub.Split("\r\n").ToList())
            });

            #endregion

            return result;
        }
            

        public static List<Lessons> GetTestData(string path)
        {

            return GetRealData(path);
        
        }

        public static List<string> GetMillis(List<string> from_arr)
        {
            List<string> mss = new List<string>();
            foreach (string s in from_arr)
            {
                string[] arr2 = s.Split('-');
                if (arr2.Length > 1)
                {
                    string date = arr2[0].Trim();
                    DateTime dateValue;

                    DateTime tv1 = DateTime.Today;

                    if (DateTime.TryParse(date, out dateValue))
                    {        
                        mss.Add(dateValue.Subtract(tv1).TotalMilliseconds.ToString());
                    }
                }
            }
            return mss;
        }

    }
}



//List<Lessons> result = new List<Lessons>();
//var rand = new Random();
//int counter = -1;

////var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "time", "Обучение ProjectWise. Пользователи (Часть 1).txt");
////FileStream fileStream = new FileStream(file, FileMode.Open);
////using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF32))
////{
////    string line = reader.ReadLine();
////}

//List<string> temp_sub = new List<string>();
//temp_sub = SubtitlesTemplateModel.sub1.Split("\r\n").ToList();

//for (int i = 0; i < 10; i++)
//{
//    //ProjectWise. Администраторы 
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "ProjectWise. Администраторы.",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                                rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//for (int i = 0; i < 10; i++)
//{
//    //ProjectWise. Пользователи 
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "ProjectWise. Пользователи.",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                               rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//for (int i = 0; i < 10; i++)
//{
//    //MicroStation. Администраторы 
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "MicroStation. Администраторы.",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                               rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//for (int i = 0; i < 10; i++)
//{
//    //MicroStation. Пользователи.
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "MicroStation. Пользователи.",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                               rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//for (int i = 0; i < 10; i++)
//{
//    //Open Roads     
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "Open Roads.",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                               rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//for (int i = 0; i < 10; i++)
//{
//    //Promise. Администраторы    
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "Promise. Администраторы",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                               rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//for (int i = 0; i < 10; i++)
//{
//    //Promise. Пользователи 
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "Promise. Пользователи",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                               rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//for (int i = 0; i < 10; i++)
//{
//    //ProStructures
//    result.Add(new Lessons()
//    {
//        ID = ++counter,
//        Title = "ProStructures",
//        Description = "День " + rand.Next(1, 10) + ". Урок " +
//                               rand.Next(1, 10) + ".",
//        Link = "Home/Video/",
//        poster = "../../images/build.jpg",
//        source = "../../video/bentley.mp4",
//        Creator = "Ирисофт",
//        Moving = rand.Next(1, 1000),
//        Rating = rand.Next(1, 10),
//        Timeline = "0:" + rand.Next(10, 50) + ":" + rand.Next(10, 50),
//        Subtitles = temp_sub,
//        JsTimings = GetMillis(temp_sub)
//    });
//}

//cashdata = result;

//return result;