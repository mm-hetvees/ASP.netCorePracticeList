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
using X.PagedList;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram27EmployeeDepartmentWiseController : Controller
    {
        private PracticeDbContext db = new PracticeDbContext();
        // GET: PracticeProgram27EmployeeDepartmentWiseController
        public ActionResult Index()
        {
            return View(db.ClientTaEmployeeDepartmentTableDetailsbleData.ToList());
        }

        // GET: PracticeProgram27EmployeeDepartmentWiseController/Details/5
        public ActionResult Details(string id)
        {
            return View(db.ClientTaEmployeeDepartmentTableDetailsbleData.Find(id));
        }

        // GET: PracticeProgram27EmployeeDepartmentWiseController/Create
        public ActionResult Create()
        {
            List<SelectListItem> lstJob = new List<SelectListItem>();
            lstJob.Add(new SelectListItem()
            {
                Text = "Manager",
                Value = "Manager",
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Developer",
                Value = "Developer",
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Business Analyst",
                Value = "Business Analyst",
            });
            ViewBag.Job = lstJob;
            List<SelectListItem> lstDepartmentName = new List<SelectListItem>();
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "Accounting",
                Value = "Accounting"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "IT",
                Value = "IT"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "HR",
                Value = "HR"
            });
            ViewBag.DepartmentName = lstDepartmentName;
            return View();
        }

        // POST: PracticeProgram27EmployeeDepartmentWiseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeDepartmentTableDetails data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.ClientTaEmployeeDepartmentTableDetailsbleData.Add(data);
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

        // GET: PracticeProgram27EmployeeDepartmentWiseController/Edit/5
        public ActionResult Edit(string id)
        {
            var employeeResponse = db.ClientTaEmployeeDepartmentTableDetailsbleData.Find(id);
            List<SelectListItem> lstJob = new List<SelectListItem>();
            lstJob.Add(new SelectListItem()
            {
                Text = "Manager",
                Value = "Manager",
                Selected = employeeResponse.Job == "Manager" ? true : false
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Developer",
                Value = "Developer",
                Selected = employeeResponse.Job == "Developer" ? true : false
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Business Analyst",
                Value = "Business Analyst",
                Selected = employeeResponse.Job == "Business Analyst" ? true : false
            });
            ViewBag.Job = lstJob;
            List<SelectListItem> lstDepartmentName = new List<SelectListItem>();
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "Accounting",
                Value = "Accounting"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "IT",
                Value = "IT"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "HR",
                Value = "HR"
            });
            ViewBag.DepartmentName = lstDepartmentName;
            ViewBag.HireDate = Convert.ToDateTime(employeeResponse.HireDate).ToString("yyyy-MM-dd");
            return View(employeeResponse);
        }

        // POST: PracticeProgram27EmployeeDepartmentWiseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, EmployeeDepartmentTableDetails data)
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

        // GET: PracticeProgram27EmployeeDepartmentWiseController/Delete/5
        public ActionResult Delete(string id)
        {
            return View(db.ClientTaEmployeeDepartmentTableDetailsbleData.Find(id));
        }

        // POST: PracticeProgram27EmployeeDepartmentWiseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, EmployeeDepartmentTableDetails data)
        {
            try
            {
                var employeeResponse = db.ClientTaEmployeeDepartmentTableDetailsbleData.Find(id);
                db.ClientTaEmployeeDepartmentTableDetailsbleData.Remove(employeeResponse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Filter()
        {
            List<SelectListItem> lstDepartmentName = new List<SelectListItem>();
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "Accounting",
                Value = "Accounting"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "IT",
                Value = "IT"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "HR",
                Value = "HR"
            });
            ViewBag.DepartmentName = lstDepartmentName;
            return View("DisplayDataDepartmentWise");
        }
        public ActionResult GetDataDepartmentWise(string departmentName)
        {
            var result = db.ClientTaEmployeeDepartmentTableDetailsbleData.Where(a => a.DepartmentName == departmentName).ToList();
            return PartialView("~/Views/PracticeProgram27EmployeeDepartmentWise/_DisplayDataDepartmentWise.cshtml",result);
        }
        public ActionResult EmployeeDataOnSelect(int? id)
        {
            var result = db.ClientTaEmployeeDepartmentTableDetailsbleData.ToList().ToPagedList(id ?? 1, 3);
            return View(result);
        }

        public ActionResult GetData(string id)
        {
            var result = db.ClientTaEmployeeDepartmentTableDetailsbleData.Where(a => a.Id == id).FirstOrDefault();
            ViewBag.partialViewData = result;
            return PartialView("~/Views/PracticeProgram27EmployeeDepartmentWise/_DisplayDataOnSelectGetData.cshtml", result);
        }
    }
}
