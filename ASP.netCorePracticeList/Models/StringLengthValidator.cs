using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Models
{
    public class StringLengthValidator
    {
        [StringLength(10,ErrorMessage ="More Than 10 Characters Are Not Allowed In Comment !!")]
        public string comment { get; set; }
    }
}
