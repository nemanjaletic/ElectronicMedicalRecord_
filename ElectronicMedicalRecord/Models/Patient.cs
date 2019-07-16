using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UCIN { get; set; } //jmbg - 	Unique Citizens Identity Number
        public string HealthInsuranceNumber { get; set; } //broj zdravstvenog osiguranja
        public string Sex { get; set; }
    }
}