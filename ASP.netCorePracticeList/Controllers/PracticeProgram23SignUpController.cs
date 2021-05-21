using ASP.netCorePracticeList.Database.Context;
using ASP.netCorePracticeList.Database.Model;
using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram23SignUpController : Controller
    {
        private PracticeDbContext db=new PracticeDbContext();
        // GET: PracticeProgram23SignUpController
        public IActionResult Index()
        {
            return View(db.UserTableDetails.ToList());
        }

        // GET: PracticeProgram23SignUpController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: PracticeProgram23SignUpController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PracticeProgram23SignUpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,FirstName,LastName,UserPassword,RetypePassword,BirthDate,Gender,UserEmail")] UserData userData, string btnAction)
        {
            if (btnAction == "Submit")
            {
                if (ModelState.IsValid)
                {
                    UserTableDetails user = new UserTableDetails();
                    user.FirstName = userData.FirstName;
                    user.LastName = userData.LastName;
                    if (userData.UserPassword == userData.RetypePassword)
                    {
                        user.UserPassword = userData.UserPassword;
                    }
                    user.BirthDate = userData.BirthDate;
                    user.Gender = userData.Gender;
                    user.UserEmail = userData.UserEmail;
                    db.UserTableDetails.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
                return View();
            }

            return View();
        }

    }
}
