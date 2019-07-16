using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public double Dose { get; set; }
        public string Drug { get; set; }
        public string Note { get; set; }


        public virtual ICollection<Publishing> Publishings{ get; set; }
    }
}