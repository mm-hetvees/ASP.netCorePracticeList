using ASP.netCorePracticeList.Database.Context;
using ASP.netCorePracticeList.Database.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram25EmployeeController : Controller
    {
        private PracticeDbContext db = new PracticeDbContext();
        // GET: PracticeProgram25EmployeeController
        public ActionResult Index()
        {
            return View(db.EmployeeTableDetails.ToList());
            //var result = db.EmployeeTableDetails.ToList();
            //return PartialView("~/Views/Shared/_DisplayData.cshtml", result);
        }

        // GET: PracticeProgram25EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.EmployeeTableDetails.Find(id));
        }

        // GET: PracticeProgram25EmployeeController/Create
        public ActionResult Create()
        {
            List<SelectListItem> lstCity = new List<SelectListItem>();
            lstCity.Add(new SelectListItem()
            {
                Text = "Ahmedabad",
                Value = "Ahmedabad"
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Canberra",
                Value = "Canberra"
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Ottawa",
                Value = "Ottawa"
            });
            ViewBag.City = lstCity;

            List<SelectListItem> lstCountry = new List<SelectListItem>();
            lstCountry.Add(new SelectListItem()
            {
                Text = "India",
                Value = "India"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Australia",
                Value = "Australia"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Canada",
                Value = "Canada"
            });
            ViewBag.Country = lstCountry;
            return View();
        }

        // POST: PracticeProgram25EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,DateOfBirth,Address,ContactNumber,City,Country")] EmployeeTableDetails data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.EmployeeTableDetails.Add(data);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: PracticeProgram25EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var EmployeeTableDetails = db.EmployeeTableDetails.Find(id);
            if (id != null)
            {
                List<SelectListItem> lstCity = new List<SelectListItem>();
                lstCity.Add(new SelectListItem()
                {
                    Text = "Ahmedabad",
                    Value = "Ahmedabad",
                    Selected = EmployeeTableDetails.City == "Ahmedabad" ? true : false
                });
                lstCity.Add(new SelectListItem()
                {
                    Text = "Canberra",
                    Value = "Canberra",
                    Selected = EmployeeTableDetails.City == "Canberra" ? true : false
                });
                lstCity.Add(new SelectListItem()
                {
                    Text = "Ottawa",
                    Value = "Ottawa",
                    Selected = EmployeeTableDetails.City == "Ottawa" ? true : false
                });
                ViewBag.City = lstCity;

                List<SelectListItem> lstCountry = new List<SelectListItem>();
                lstCountry.Add(new SelectListItem()
                {
                    Text = "India",
                    Value = "India",
                    Selected = EmployeeTableDetails.Country == "India" ? true : false
                });
                lstCountry.Add(new SelectListItem()
                {
                    Text = "Australia",
                    Value = "Australia",
                    Selected = EmployeeTableDetails.Country == "Australia" ? true : false
                });
                lstCountry.Add(new SelectListItem()
                {
                    Text = "Canada",
                    Value = "Canada",
                    Selected = EmployeeTableDetails.Country == "Canada" ? true : false
                });
                ViewBag.Country = lstCountry;
                return View(EmployeeTableDetails);
            }
            return View("Index");
        }

        // POST: PracticeProgram25EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,DateOfBirth,Address,ContactNumber,City,Country")] EmployeeTableDetails data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(data).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: PracticeProgram25EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var EmployeeTableDetails = db.EmployeeTableDetails.Find(id);
            if (id != null)
            {
                return View(EmployeeTableDetails);
            }
                return View("Index");
        }

        // POST: PracticeProgram25EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EmployeeTableDetails data)
        {
            try
            {
                EmployeeTableDetails emploeeTableResponse = db.EmployeeTableDetails.Find(id);
                db.EmployeeTableDetails.Remove(emploeeTableResponse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
