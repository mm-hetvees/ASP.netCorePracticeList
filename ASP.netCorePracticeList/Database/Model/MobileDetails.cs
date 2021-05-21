using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Database.Model
{
    public class MobileDetails
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public Nullable<long> ModelPrice { get; set; }
        public string ModelImage { get; set; }
    }
}
