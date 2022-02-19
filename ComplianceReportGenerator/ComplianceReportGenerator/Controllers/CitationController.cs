using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplianceReportGenerator.Controllers
{
    public class CitationController : Controller
    {
        public IActionResult citation()
        {
            return View();
        }
    }
}
