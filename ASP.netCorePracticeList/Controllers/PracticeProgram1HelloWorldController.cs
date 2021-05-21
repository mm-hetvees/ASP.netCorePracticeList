using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram1HelloWorldController : Controller
    {
        // GET: PracticeProgram1HelloWorldController
        public IActionResult Index()
        {
            return View();
        }
    }
}
