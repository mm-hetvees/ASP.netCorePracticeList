using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram16RegisterationWithValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegisterationWithValidators model)
        {
            if (ModelState.IsValid)
            {
                RegisterationWithValidators objResult = new RegisterationWithValidators();
                objResult.FirstName = model.FirstName;
                objResult.LastName = model.LastName;
                objResult.age = model.age;
                objResult.Password = model.Password;
                objResult.ConfirmPassword = model.ConfirmPassword;
                objResult.Email = model.Email;
                ViewBag.result = objResult;
            }
            return View();
        }
    }
}
