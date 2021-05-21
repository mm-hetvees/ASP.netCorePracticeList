using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram19PassDataToSecondPageController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> lstThings = new List<SelectListItem>();
            lstThings.Add(new SelectListItem()
            {
                Text = "Monitor",
                Value = "Monitor"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "CPU",
                Value = "CPU"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "Keyboard",
                Value = "Keyboard"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "Mouse",
                Value = "Mouse"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "GamePad",
                Value = "GamePad"
            });
            ViewBag.ddlThings = lstThings;
            return View();
        }
        [HttpPost]
        public IActionResult Index(string ddlThings, string chkShowDetails)
        {
            List<SelectListItem> lstThings = new List<SelectListItem>();
            lstThings.Add(new SelectListItem()
            {
                Text = "Monitor",
                Value = "Monitor"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "CPU",
                Value = "CPU"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "Keyboard",
                Value = "Keyboard"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "Mouse",
                Value = "Mouse"
            });
            lstThings.Add(new SelectListItem()
            {
                Text = "GamePad",
                Value = "GamePad"
            });
            ViewBag.ddlThings = lstThings;
            return RedirectToAction("TransferData", new ModelTransfer() { dropdownVal = "Item : " + ddlThings, chkChoiceVal = "Show Full Record : " + chkShowDetails });
        }

        public ActionResult TransferData(ModelTransfer m)
        {

            return View("DisplayData", m);
        }
    }
}
