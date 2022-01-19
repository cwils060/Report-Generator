using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplianceReportGenerator.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Test()
        {

        }
        public Test(string name)
        {
            Name = name;
        }
    }
}
