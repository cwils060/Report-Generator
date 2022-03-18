using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComplianceReportGenerator.Models
{
    public class ClientFormViewModel
    {
        public int Id { get; set; }
        static private int nextId = 1;
        public List<Citation> Citations { get; set; }
        [Required(ErrorMessage ="Date is required")]
        /*[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yy}")]*/
        [DataType(DataType.Date)]
        public DateTime Date {get; set; }
        [Required(ErrorMessage = "Client is required")]
        public string ClientName { get; set; }
        [Required(ErrorMessage = "Client representative is required")]
        public string ClientRep { get; set; }
        public bool Staff { get; set; }
        [Required(ErrorMessage = "Facility type is required")]
        public string FacilityType { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        public ClientFormViewModel()
        {
            Id = nextId;
            nextId++;
        }
        
        public ClientFormViewModel(DateTime date, string clientName, string clientRep, bool staff, string facilityType, string address, List<Citation> citations):this ()
        {
            Date = date;
            ClientName = clientName;
            ClientRep = clientRep;
            Staff = staff;
            FacilityType = facilityType;
            Address = address;
            Citations = citations;
        }

        public override string ToString()
        {
            /*var y = "";
            for (int i = 0; i < this.Citations.Count; i++)
            {
                y += Citations[i].ToString();
            }
            return y;*/
            string output = "";

           
            
            output = string.Format( 
                    "Date of Audit: \n" +
                    "Client Name: \n" +
                    "Client Rep: \n" +
                    "Facility Type: \n" +
                    "Address: \n", Date, ClientName, ClientRep, FacilityType, Address);

            return output;
        }

        public override bool Equals(object obj)
        {
            return obj is ClientFormViewModel clientFormViewModel &&
                   Id == clientFormViewModel.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }



    }
}
