using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Models
{
    public class Marksheet
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string WebProgrammingMarks { get; set; }
        public string ComputerNetworkMarks { get; set; }
        public string BuisnessInformationSystemMarks { get; set; }
        public string SystemSoftwareMarks { get; set; }
        public string InformationSecurityMarks { get; set; }
    }
}
