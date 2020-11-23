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
    public class VideoController : Controller
    {
        public ActionResult Videos_Read([DataSourceRequest] DataSourceRequest request)
        {      
            var dsResult = Video.GetTestData().ToDataSourceResult(request);
            return Json(dsResult);
        }

 
    }
}
