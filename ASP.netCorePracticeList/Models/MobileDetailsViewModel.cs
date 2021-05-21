using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Models
{
    public class MobileDetailsViewModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public Nullable<long> ModelPrice { get; set; }
        public IFormFile ModelImage { get; set; }
    }
}
