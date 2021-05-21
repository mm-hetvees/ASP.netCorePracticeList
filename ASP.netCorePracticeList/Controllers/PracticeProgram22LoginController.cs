using ASP.netCorePracticeList.Database.Context;
using ASP.netCorePracticeList.Database.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram22LoginController : Controller
    {
        private PracticeDbContext db = new PracticeDbContext();
        // GET: PracticeProgram22LoginController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserTableDetails obj, string btnAction)
        {
            if (btnAction == "Login")
            {
                if (ModelState.IsValid)
                {
                    var res = db.UserTableDetails.Where(a => a.UserEmail.Equals(obj.UserEmail) && a.UserPassword.Equals(obj.UserPassword)).FirstOrDefault();
                    if (res != null)
                    {
                        ViewBag.Result = "Logged In Succesfully!!";
                    }
                    else
                    {
                        ViewBag.Result = "Please Check Your EmailId & Password!!";
                    }
                }
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
        // GET: PracticeProgram22LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PracticeProgram22LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PracticeProgram22LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PracticeProgram22LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PracticeProgram22LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PracticeProgram22LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PracticeProgram22LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
