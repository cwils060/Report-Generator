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
                    Address = clientFormViewModel.Address,
                    Citations = clientFormViewModel.Citations
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


        //this starts the search functionality

        private ReportDbContext context;

        public ClientFormController(ReportDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Result(string searchTerm)
        {
            
            //List<ClientFormViewModel> displayCitations = new List<ClientFormViewModel>();

            var displayCitations = from dc in context.Citations
                         select dc;

            if (!String.IsNullOrEmpty(searchTerm))
            {
                displayCitations = displayCitations.Where(s => s.Summary!.Contains(searchTerm));
            }

            ViewBag.displayCitations = displayCitations.ToList();
            return Ok(ViewBag.displayCitations);
            
        }

            /*else
            {
                if (searchType == "employer")
                {
                    jobs = context.Jobs
                        .Include(j => j.Employer)
                        .Where(j => j.Employer.Name == searchTerm)
                        .ToList();

                    foreach (Job job in jobs)
                    {
                        List<JobSkill> jobSkills = context.JobSkills
                        .Where(js => js.JobId == job.Id)
                        .Include(js => js.Skill)
                        .ToList();

                        JobDetailViewModel newDisplayJob = new JobDetailViewModel(job, jobSkills);
                        displayJobs.Add(newDisplayJob);
                    }

                }
                else if (searchType == "skill")
                {
                    List<JobSkill> jobSkills = context.JobSkills
                        .Where(j => j.Skill.Name == searchTerm)
                        .Include(j => j.Job)
                        .ToList();

                    foreach (var job in jobSkills)
                    {
                        Job foundJob = context.Jobs
                            .Include(j => j.Employer)
                            .Single(j => j.Id == job.JobId);

                        List<JobSkill> displaySkills = context.JobSkills
                            .Where(js => js.JobId == foundJob.Id)
                            .Include(js => js.Skill)
                            .ToList();

                        JobDetailViewModel newDisplayJob = new JobDetailViewModel(foundJob, displaySkills);
                        displayJobs.Add(newDisplayJob);
                    }
                }
            }

            ViewBag.columns = ListController.ColumnChoices;
            ViewBag.title = "Jobs with " + ListController.ColumnChoices[searchType] + ": " + searchTerm;
            ViewBag.jobs = displayJobs;

            return View("Index");
        }*/

    }
}
