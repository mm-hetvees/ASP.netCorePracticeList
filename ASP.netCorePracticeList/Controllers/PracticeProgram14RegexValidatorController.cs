using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram14RegexValidatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RegexValidator model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Email = "Entered Email Is : " + model.Email;
            }
            return View();
        }
    }
}
