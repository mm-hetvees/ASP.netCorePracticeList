using ASP.netCorePracticeList.Database.Context;
using ASP.netCorePracticeList.Database.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram24CustomerEntryController : Controller
    {
        private PracticeDbContext db = new PracticeDbContext();
        // GET: PracticeProgram24CustomerEntryController
        public IActionResult Index()
        {
            return View(db.CustomerEntryTable.ToList());
        }

        // GET: PracticeProgram24CustomerEntryController/Create
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
            ViewBag.CustomerCity = lstCity;

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
            ViewBag.CustomerCountry = lstCountry;
            return View();
        }

        // POST: PracticeProgram24CustomerEntryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,CustomerName,Customeraddress,CustomerContactNo,CustomerCity,CustomerCountry")] CustomerEntryTable model,string btnAction)
        {
            try
            {
                if (btnAction == "Submit") {
                    if (ModelState.IsValid)
                    {
                        db.CustomerEntryTable.Add(model);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                if (btnAction == "Reset") {
                    ModelState.Clear();
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
                    ViewBag.CustomerCity = lstCity;

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
                    ViewBag.CustomerCountry = lstCountry;
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

    }
}
