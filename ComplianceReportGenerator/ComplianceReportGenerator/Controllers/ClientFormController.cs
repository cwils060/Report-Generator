using ComplianceReportGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplianceReportGenerator.Controllers
{
    public class ClientFormController : Controller
    {
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
        
        public ClientFormViewModel CreateClientForm(DateTime date, string clientName, string clientRep, bool staff, string facilityType, string address)
        {
            ClientFormViewModel clientFormViewModel = new ClientFormViewModel(date, clientName, clientRep, staff, facilityType, address);
            return clientFormViewModel;
        }
    }
}
