using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class Hospital
    {
        public int HospitalID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Employed> Employeds{ get; set; }

    }
}