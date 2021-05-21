using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram2TextboxDataDsiplayController : Controller
    {
        // GET: PracticeProgram2TextboxDataDsiplayController
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TextBoxDataDisplay model)
        {
            ViewBag.data = "Entered Value Is :" + model.name;
            return View();
        }
    }
}
