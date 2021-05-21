using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Models
{
    public class CompareValidator
    {
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password & Confirm Password Must Be Same !!")]
        public string RetypePassword { get; set; }
    }
}
