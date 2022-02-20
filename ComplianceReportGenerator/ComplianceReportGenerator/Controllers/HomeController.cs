using ComplianceReportGenerator.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ComplianceReportGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

    
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return LocalRedirect("/Identity/Account/Login");
            }
        }
        [HttpPost]
        public ActionResult createform1(DateTime txtDate, string txtAddress, string txtClientName, string txtClientRep, string txtFacilityType, string chkStaff)

        {

            ViewBag.Date = txtDate;

            ViewBag.Adress = txtAddress;
            ViewBag.ClientName = txtClientName;
            ViewBag.ClientRep = txtClientRep;
            ViewBag.FacilityType = txtFacilityType;

            if (chkStaff != null)

                ViewBag.Staff = "Selected";

            else

                ViewBag.Staff = "Not Selected";



            return View();

        }
        public IActionResult createform()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
