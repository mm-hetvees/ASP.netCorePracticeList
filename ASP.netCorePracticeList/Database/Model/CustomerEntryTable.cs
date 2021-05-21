using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Database.Model
{
    public class CustomerEntryTable
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Customeraddress { get; set; }
        public string CustomerContactNo { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
    }
}
