using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram15StringLengthValidatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(StringLengthValidator model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.comment = model.comment;
            }
            return View();
        }
    }
}
