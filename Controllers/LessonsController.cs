using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;
using VideoLessons.Models;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Hosting;

namespace VideoLessons.Controllers
{
    public class LessonsController : Controller
    {

        private IWebHostEnvironment Environment;

        public LessonsController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }

        public ActionResult VideoLessons()
        {
            return View();
        }


        public ActionResult Lessons_Read([DataSourceRequest] DataSourceRequest request)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;
            if (Lessons.cashdata.Count() == 0)
            {
                Lessons.cashdata = Lessons.GetTestData(wwwPath);
            }
            var dsResult = Lessons.cashdata.OrderBy(d => d.ID_sort).ToDataSourceResult(request); //.OrderBy(d => d.ID)
            return Json(dsResult);
        }

        public ActionResult GetJS()
        {
            byte[] jsDATA = System.Text.ASCIIEncoding.ASCII.GetBytes("var move1 = function () " +
                "{ mediaPlayer.seek(0); mediaPlayer.play(); }; $(\"#go_1\").click(move1);");
            return File(jsDATA, "text/javascript");
        }
    }
}
