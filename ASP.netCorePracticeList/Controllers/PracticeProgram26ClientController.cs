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
    public class PracticeProgram26ClientController : Controller
    {
        private PracticeDbContext db = new PracticeDbContext();
        // GET: PracticeProgram26ClientController
        public ActionResult Index()
        {
            return View(db.ClientTableData.ToList());
        }

        // GET: PracticeProgram26ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ClientTableData.Find(id));
        }

        // GET: PracticeProgram26ClientController/Create
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
                Text = "Patna",
                Value = "Patna"
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Mumbai",
                Value = "Mumbai"
            });
            ViewBag.City = lstCity;

            List<SelectListItem> lstState = new List<SelectListItem>();
            lstState.Add(new SelectListItem()
            {
                Text = "Gujarat",
                Value = "Gujarat"
            });
            lstState.Add(new SelectListItem()
            {
                Text = "Bihar",
                Value = "Bihar"
            });
            lstState.Add(new SelectListItem()
            {
                Text = "Maharashtra",
                Value = "Maharashtra"
            });
            ViewBag.State = lstState;
            return View();
        }

        // POST: PracticeProgram26ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ClientNumber,ClientName,Address,City,State,Pincode")] ClientTableData client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.ClientTableData.Add(client);
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

        // GET: PracticeProgram26ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            if(id!=null)
            {
                var clientDataResponse = db.ClientTableData.Find(id);
                List<SelectListItem> lstCity = new List<SelectListItem>();
                lstCity.Add(new SelectListItem()
                {
                    Text = "Ahmedabad",
                    Value = "Ahmedabad"
                });
                lstCity.Add(new SelectListItem()
                {
                    Text = "Patna",
                    Value = "Patna"
                });
                lstCity.Add(new SelectListItem()
                {
                    Text = "Mumbai",
                    Value = "Mumbai"
                });
                ViewBag.City = lstCity;

                List<SelectListItem> lstState = new List<SelectListItem>();
                lstState.Add(new SelectListItem()
                {
                    Text = "Gujarat",
                    Value = "Gujarat"
                });
                lstState.Add(new SelectListItem()
                {
                    Text = "Bihar",
                    Value = "Bihar"
                });
                lstState.Add(new SelectListItem()
                {
                    Text = "Maharashtra",
                    Value = "Maharashtra"
                });
                ViewBag.State = lstState;
                return View(clientDataResponse);
            }
            return View("Index");
        }

        // POST: PracticeProgram26ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("ClientNumber,ClientName,Address,City,State,Pincode")] ClientTableData client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(client).State = EntityState.Modified;
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

        // GET: PracticeProgram26ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.ClientTableData.Find(id));
        }

        // POST: PracticeProgram26ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClientTableData client)
        {
            try
            {
                ClientTableData clientTableResponse = db.ClientTableData.Find(id);
                db.ClientTableData.Remove(clientTableResponse);
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
