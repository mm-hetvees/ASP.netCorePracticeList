using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram11RequiredFieldValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RequiredField model, string btnAction)
        {
            if (btnAction == "Submit")
            {

                if (ModelState.IsValid)
                {
                    ViewBag.FirstName = model.FirstName;
                    ViewBag.LastName = model.LastName;
                }
            }
            if (btnAction == "Reset") {
                ModelState.Clear();
            }
                return View();
        }
    }
}
