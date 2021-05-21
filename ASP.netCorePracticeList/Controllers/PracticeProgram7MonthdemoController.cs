using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram7MonthdemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MonthData model, string btnAction)
        {
            if (btnAction == "submit")
            {
                switch (model.monthNo)
                {
                    case 1:
                        model.monthName = "January";
                        break;
                    case 2:
                        model.monthName = "February";
                        break;
                    case 3:
                        model.monthName = "March";
                        break;
                    case 4:
                        model.monthName = "April";
                        break;
                    case 5:
                        model.monthName = "May";
                        break;
                    case 6:
                        model.monthName = "June";
                        break;
                    case 7:
                        model.monthName = "July";
                        break;
                    case 8:
                        model.monthName = "August";
                        break;
                    case 9:
                        model.monthName = "September";
                        break;
                    case 10:
                        model.monthName = "October";
                        break;
                    case 11:
                        model.monthName = "November";
                        break;
                    case 12:
                        model.monthName = "December";
                        break;
                    default:
                        model.monthName = "Invalid";
                        break;
                }
            }
            if (btnAction == "reset")
            {
                ModelState.Clear();
                return View();
            }

            return View(model);
        }
    }
}
