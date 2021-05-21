using ASP.netCorePracticeList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ASP.netCorePracticeList.Controllers
{
    public class PracticeProgram20AdRotatorController : Controller
    {
        private IHostingEnvironment _env;
        public PracticeProgram20AdRotatorController(IHostingEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            var xmlData = System.IO.Path.Combine(_env.WebRootPath, "Employee.xml");
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var employees = new List<Employee>();
            employees = (from rows in ds.Tables[0].AsEnumerable()
                         select new Employee
                         {
                             EmployeeId = Convert.ToInt32(rows[0].ToString()), //Convert row to int  
                             EmployeeName = rows[1].ToString(),
                             EmployeeSalary = Convert.ToInt64(rows[2].ToString()),
                         }).ToList();
            return View("Index", employees);
        }
    }
}
