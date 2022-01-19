using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplianceReportGenerator.Models
{
    public class Test2
    {
        public int Id { get; set; }
        public string Location { get; set; }

        public Test2()
        {

        }
        public Test2(string location)
        {
            Location = location;
        }
    }
}
