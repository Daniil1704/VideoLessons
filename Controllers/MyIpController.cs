using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VideoLessons.Controllers
{
    public class MyIpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
