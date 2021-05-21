using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram3ArithmeticOperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ArithmeticOperation model, string btnAction)
        {
            if (btnAction == "+")
            {
                ViewBag.ans = model.no1 + model.no2;
            }
            else if (btnAction == "-")
            {
                ViewBag.ans = model.no1 - model.no2;
            }
            else if (btnAction == "*")
            {
                ViewBag.ans = model.no1 * model.no2;
            }
            else
            {
                if (model.no1 != 0 && model.no2 != 0)
                {
                    ViewBag.ans = model.no1 / model.no2;
                }
                else
                {
                    ViewBag.ans = 0;
                }
            }
            return View();
        }
    }
}
