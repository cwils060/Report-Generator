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

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yy}")]
        public DateTime Date {get; set; }
        public string ClientName { get; set; }
        public string ClientRep { get; set; }
        public bool Staff { get; set; }
        public string FacilityType { get; set; }
        public string Address { get; set; }

        
        public ClientFormViewModel(DateTime date, string clientName, string clientRep, bool staff, string facilityType, string address)
        {
            Date = date;
            ClientName = clientName;
            ClientRep = clientRep;
            Staff = staff;
            FacilityType = facilityType;
            Address = address;
        }
    }

}
