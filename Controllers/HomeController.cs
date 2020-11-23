using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using VideoLessons.Models;


namespace VideoLessons.Controllers
{
    public class HomeController : Controller
    {

        private IWebHostEnvironment Environment;

        public HomeController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Некоторая информация.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Дополнительная информация.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Video(int v_id)
        {
            if (Lessons.cashdata.Count() == 0)
            {
                string wwwPath = this.Environment.WebRootPath;
                Lessons.cashdata = Lessons.GetTestData(wwwPath);
            }
            Lessons one_les = Lessons.cashdata[0];
            if (v_id > -1)
            {
                int couter = Lessons.cashdata.Count;
                for (int i = 0; i < couter; i++)
                {
                    if (Lessons.cashdata[i].ID == v_id)
                    {
                        one_les = Lessons.cashdata[i];
                        Lessons.cashdata[i].Moving+=1;
                        break;
                    }
                }
            }
            ViewBag.Lesson = one_les;
            return View(); 
        }

        [HttpPost]
        public IActionResult AddRating(int v_id)
        {
            int couter = Lessons.cashdata.Count;
            for (int i = 0; i < couter; i++)
            {
                if (Lessons.cashdata[i].ID == v_id)
                {
                    if (Lessons.cashdata[i].Rating < 10)
                      Lessons.cashdata[i].Rating += 1;
                    break;
                }
            }
            return View();
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }



    }
}
