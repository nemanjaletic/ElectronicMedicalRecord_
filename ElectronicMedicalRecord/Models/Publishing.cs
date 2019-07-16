using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class Publishing
    {
        public int PublishingID { get; set; }
        public int MedicalCertificatesID { get; set; }
        public int DrugPrescriptionID { get; set; }
        public DateTime Date { get; set; }
    }
}