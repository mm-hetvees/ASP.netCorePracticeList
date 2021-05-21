using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram21MasterPageController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Home page of my application";
            return View();
        }

        public IActionResult AboutMasterPage()
        {
            ViewBag.Message = "Description page of my application";
            return View();
        }

        public IActionResult ContactMasterPage()
        {
            ViewBag.Message = "Contact page of my application";
            return View();
        }
    }
}
