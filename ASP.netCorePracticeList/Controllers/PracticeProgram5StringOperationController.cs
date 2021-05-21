using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram5StringOperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string RadioChoice, string inputString)
        {
            switch (RadioChoice)
            {
                case "UpperCase":
                    ViewBag.Response = inputString.ToUpper();
                    break;
                case "LowerCase":
                    ViewBag.Response = inputString.ToLower();
                    break;
                case "LeftCharacters":
                    ViewBag.Response = inputString.Substring(0, 5);
                    break;
                case "RightCharacters":
                    ViewBag.Response = inputString.Substring(inputString.Length-5);
                    break;
                default:
                    ViewBag.Response = "Invalid";
                    break;
            }
            return View();
        }
    }
}
