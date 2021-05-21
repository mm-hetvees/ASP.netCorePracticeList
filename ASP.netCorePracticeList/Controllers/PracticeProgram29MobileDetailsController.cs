using ASP.netCorePracticeList.Database.Context;
using ASP.netCorePracticeList.Database.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using static System.Net.WebRequestMethods;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram29MobileDetailsController : Controller
    {
        PracticeDbContext db = new PracticeDbContext();
        private IHostingEnvironment _env;
        public PracticeProgram29MobileDetailsController(IHostingEnvironment env)
        {
            _env = env;
        }
        // GET: PracticeProgram29MobileDetailsController
        public ActionResult Index()
        {
            return View(db.MobileDetails.ToList());
        }

        // GET: PracticeProgram29MobileDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PracticeProgram29MobileDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,ModelName,ModelPrice,ModelImage")] MobileDetails data, IFormFile MobileImage)
        {
            if (ModelState.IsValid)
            {
                var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".PNG", ".JPEG" };
                MobileDetails mobileData = new MobileDetails();
                mobileData.ModelName = data.ModelName;
                mobileData.ModelPrice = data.ModelPrice;
                var fileName = Path.GetFileName(MobileImage.FileName);//for fetching fileName
                var fileExtension = Path.GetExtension(MobileImage.FileName);//for fetching extension
                if (allowedExtensions.Contains(fileExtension)) //check what type of extension  
                {
                    string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
                    string myfile = name + fileExtension;
                    var path = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(path, myfile);
                    mobileData.ModelImage = myfile;
                    db.MobileDetails.Add(mobileData);
                    db.SaveChanges();
                    //MobileImage.SaveAs(path);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        MobileImage.CopyTo(fileStream);
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.message = "Please choose only Image file";
                }

            }

            return View(data);
        }

        public ActionResult FilterData()
        {
            return View("FilterData");
        }
        public ActionResult GetDataOnFilter(int minimumamount, int maximumamount)
        {
            var result = db.MobileDetails.Where(a => a.ModelPrice >= minimumamount && a.ModelPrice <= maximumamount).ToList();
            return PartialView("~/Views/PracticeProgram29MobileDetails/_FilterDataDisplay.cshtml", result);
        }
    }
}
