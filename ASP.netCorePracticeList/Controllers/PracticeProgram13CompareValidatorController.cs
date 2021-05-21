using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram13CompareValidatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CompareValidator model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Password = model.Password;
                ViewBag.ConfirmPassword = model.RetypePassword;
            }
            return View();
        }
    }
}
