﻿using ComplianceReportGenerator.Models;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComplianceReportGenerator.Data;


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
        public IActionResult CreateClientForm(int[] citationIds, ClientFormViewModel clientFormViewModel)
        {
            
            var citationList = new List<Citation>();
            foreach (var id in citationIds)
            {
                citationList.Add(context.Citations.Find(id));
            }
            if (ModelState.IsValid)
            {
                ClientFormViewModel newClientForm = new ClientFormViewModel
                {
                    Date = clientFormViewModel.Date,
                    ClientName = clientFormViewModel.ClientName,
                    ClientRep = clientFormViewModel.ClientRep,
                    Staff = clientFormViewModel.Staff,
                    FacilityType = clientFormViewModel.FacilityType,
                    Address = clientFormViewModel.Address,
                    Citations = citationList
                };

                return CreateWordDoc(newClientForm);

                
            }
            return LocalRedirect("/Home/Createform");
        }

        public ActionResult CreateWordDoc(ClientFormViewModel newClientForm)
        {
            MemoryStream ms;

            var x = ViewBag.displayCitations;


            using (ms = new MemoryStream())
            {
                using WordprocessingDocument wordDocument = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document);
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    mainPart.Document = new Document(
                        new Body(
                            new Paragraph(
                                new Run(
                                    new Text($"Date of Audit: {newClientForm.Date}"))),
                            new Paragraph(
                                new Run(
                                    new Text($"Client Name: {newClientForm.ClientName}"))),
                            new Paragraph(
                                new Run(
                                    new Text($"Client Rep: {newClientForm.ClientRep}"))),
                            new Paragraph(
                                new Run(
                                    new Text($"Facility Type: {newClientForm.FacilityType}"))),
                            new Paragraph(
                                new Run(
                                    new Text($"Address: {newClientForm.Address}"))),
                            new Paragraph(
                                new Run(
                                    new Text($"Citations: \n{newClientForm}")))));
                   
                }
                
            }
            return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Compliance1-Report.docx");
        
        }


        //this starts the search functionality

        private ReportDbContext context;

        public ClientFormController(ReportDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Result(ClientFormViewModel newClientForm, string searchTerm)
        {
            
            //List<ClientFormViewModel> displayCitations = new List<ClientFormViewModel>();

            var displayCitations = from dc in context.Citations
                         select dc;

            if (!String.IsNullOrEmpty(searchTerm))
            {
                displayCitations = displayCitations.Where(s => s.Summary!.Contains(searchTerm));
            }

            //ViewBag.displayCitations = displayCitations.ToList();

            newClientForm.Citations = displayCitations.ToList();


            return View("~/Views/Home/CreateForm.cshtml", newClientForm);
        }
    }
}
