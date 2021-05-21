using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Database.Model
{
    public class EmployeeDepartmentTableDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<long> Salary { get; set; }
        public Nullable<long> Commision { get; set; }
        public string DepartmentName { get; set; }
    }
}
