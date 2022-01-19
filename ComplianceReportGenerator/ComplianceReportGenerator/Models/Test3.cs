using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplianceReportGenerator.Models
{
    public class Test3
    {
        public int Id { get; set; }
        public string Pastry { get; set; }

        public Test3()
        {

        }
        public Test3(string pastry)
        {
            Pastry = pastry;
        }
    }
}

