using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class Publishing
    {
        public int PublishingID { get; set; }
        [Column(Order = 0)]
        public int? DoctorID { get; set; }
        [Column(Order = 1)]
        public int? MedicalCertificatesID { get; set; }
        [Column(Order = 2)]
        public int? PrescriptionID { get; set; }
        public DateTime Date { get; set; }

        public virtual Employed Employed { get; set; }
        public virtual  MedicalCertificates MedicalCertificates { get; set; }
        public virtual Prescription Prescription{ get; set; }

    }
}