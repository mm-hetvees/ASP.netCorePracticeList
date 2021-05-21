using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram4NumericOperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int No, string RadioChoice)
        {
            switch (RadioChoice)
            {
                case "Even Or Odd":
                    if (No % 2 == 0)
                    {
                        ViewBag.Ans = "Number Is Even";
                    }
                    else
                    {
                        ViewBag.Ans = "Number Is Odd";
                    }
                    break;
                case "Positive Or Negative":
                    if (No < 0)
                    {
                        ViewBag.Ans = "Number Is Negative";
                    }
                    else if (No > 0)
                    {
                        ViewBag.Ans = "Number Is Positive";
                    }
                    else
                    {
                        ViewBag.Ans = "Number Is Zero";
                    }
                    break;
                case "Square":
                    var ans = 0;
                    if (No != 0)
                    {
                        ans = No * No;
                        ViewBag.Ans = "Square Is : " + Convert.ToString(ans);
                    }
                    else
                    {
                        ViewBag.Ans = "0 Is Not Allowed";
                    }
                    break;
                case "Factorial":
                    var fact = 1;
                    if(No != 0)
                    {
                        while(No > 0)
                        {
                            fact = fact * No;
                            No--;
                        }
                        ViewBag.Ans = "Factorial Is : " + Convert.ToString(fact);
                    }
                    else
                    {
                        ViewBag.Ans = "0 Is Not Allowed";
                    }
                    break;
                default:
                    ViewBag.Ans = "Invalid Choice";
                    break;
            }
            return View();
        }
    }
}
