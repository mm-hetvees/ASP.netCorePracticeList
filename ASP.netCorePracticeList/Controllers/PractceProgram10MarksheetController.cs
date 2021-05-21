using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PractceProgram10MarksheetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Marksheet model, string btnAction)
        {
            if (btnAction == "Calculate")
            {
                var ans = 0;
                ans = int.Parse(model.WebProgrammingMarks) + int.Parse(model.ComputerNetworkMarks) + int.Parse(model.BuisnessInformationSystemMarks) + int.Parse(model.SystemSoftwareMarks) + int.Parse(model.InformationSecurityMarks);
                ViewBag.total = ans.ToString();
                var percentageVal = ans * 100 / 500;
                ViewBag.percentage = (percentageVal.ToString()) + "%";
                if (percentageVal > 80)
                {
                    ViewBag.grade = "A+";
                }
                else if (percentageVal > 70 && percentageVal <= 80)
                {
                    ViewBag.grade = "A";
                }
                else if (percentageVal > 60 && percentageVal <= 70)
                {
                    ViewBag.grade = "B+";
                }
                else if (percentageVal > 50 && percentageVal <= 60)
                {
                    ViewBag.grade = "B";
                }
                else if (percentageVal > 40 && percentageVal <= 50)
                {
                    ViewBag.grade = "C";
                }
                else
                {
                    ViewBag.grade = "D";
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
