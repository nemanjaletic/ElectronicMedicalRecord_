using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class Employed
    {
        public int EmployedID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string UCIN { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int HospitalID { get; set; }



        public virtual ICollection<MedicalExamination> MedicalExaminations{ get; set; }
        public virtual ICollection<Publishing> Publishings{ get; set; }
    }
}