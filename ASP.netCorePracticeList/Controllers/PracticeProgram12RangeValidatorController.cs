using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram12RangeValidatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RangeValidator model, string btnAction)
        {
            if (btnAction == "Submit")
            {
                if (ModelState.IsValid)
                {
                    ViewBag.Age = model.age;
                }
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
