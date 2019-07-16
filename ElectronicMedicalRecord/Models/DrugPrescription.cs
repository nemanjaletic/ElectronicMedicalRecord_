using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class DrugPrescription
    {
        public int DrugPrescriptionID { get; set; }
        public double Dose { get; set; }
        public string Drug { get; set; }
        public string Note { get; set; }

    }
}