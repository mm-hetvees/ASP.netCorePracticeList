using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram6ImageDisplayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string radioChoice)
        {
            switch (radioChoice)
            {
                case "blueHills":
                    ViewBag.result = "~/Images/bluehills.jpg";
                    break;
                case "sunset":
                    ViewBag.result = "~/Images/sunset.jpg";
                    break;
                case "waterLilis":
                    ViewBag.result = "~/Images/waterlilis.jpg";
                    break;
                case "winter":
                    ViewBag.result = "~/Images/winter.jpg";
                    break;
                default:
                    ViewBag.result = "~/Images/bluehills.jpg";
                    break;
            }
            return View();
        }

    }
}
