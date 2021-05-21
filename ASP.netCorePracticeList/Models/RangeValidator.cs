using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Models
{
    public class RangeValidator
    {
        [Range(10,20,ErrorMessage ="Enter Age Between 10 & 20 !!")]
        public int age { get; set; }
    }
}
