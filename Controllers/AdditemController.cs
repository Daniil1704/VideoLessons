using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using VideoLessons.Models;

namespace VideoLessons.Controllers
{
    public partial class FormController : Controller
    {
    
        public IActionResult Index()
        {
            return View(new Lessons()
            {
                ID = Lessons.cashdata[Lessons.cashdata.Count - 1].ID,
                Title = "Обучение администраторов ProjectWise",
                Description = "День 1, Часть 1",
                Link = "Home/Video/",
                poster = "../../images/build.jpg",
                source = "../../video/Гипроникель. Обучение Администраторов ProjectWise (День 1, Часть 1).mp4",
                Creator = "Штурцев Владимир",
                Moving = 1,
                Rating = 5,
                Timeline = "1:29:10",
                Subtitles = SubtitlesTemplateModel.sub11.Split("\r\n").ToList(),
                JsTimings = Lessons.GetMillis(SubtitlesTemplateModel.sub11.Split("\r\n").ToList())
            });
        }

  
        [HttpPost]
        public ActionResult Index(Lessons model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TempData["View"] = "Index";
                return View("Success");
            }
        }

    
        public IActionResult Success()
        {
            ViewBag.View = TempData["View"];

            return View();
        }
    }
}