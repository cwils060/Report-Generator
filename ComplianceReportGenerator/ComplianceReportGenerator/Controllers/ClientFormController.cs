using ComplianceReportGenerator.Models;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        
      [HttpPost]
        public IActionResult CreateClientForm(ClientFormViewModel clientFormViewModel)
        {
           if (ModelState.IsValid)
            {
                ClientFormViewModel newClientForm = new ClientFormViewModel
                {
                    Date = clientFormViewModel.Date,
                    ClientName = clientFormViewModel.ClientName,
                    ClientRep = clientFormViewModel.ClientRep,
                    Staff = clientFormViewModel.Staff,
                    FacilityType = clientFormViewModel.FacilityType,
                    Address = clientFormViewModel.Address
                };

                return CreateWordDoc(newClientForm);

                
            }
            return LocalRedirect("/Home/Createform");
        }

        
        public ActionResult CreateWordDoc(ClientFormViewModel newClientForm)
        {
            MemoryStream ms;

           
        
            using (ms = new MemoryStream())
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    mainPart.Document = new Document(
                        new Body(
                            new Paragraph(
                                new Run(
                                    new Text($"Date of Audit {newClientForm.Date} \n Client Name: {newClientForm.ClientName} \n Client Rep: {newClientForm.ClientRep} \n Facility Type: {newClientForm.FacilityType} \n Address:{newClientForm.Address}"))))); ;
                }
            }

            return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Compliance-Report.docx");
        }

    }
}
