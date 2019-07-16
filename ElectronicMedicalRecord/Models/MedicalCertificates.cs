using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class MedicalCertificates
    {
        public int MedicalCertificatesID { get; set; }
        public string Purpose { get; set; }
        public string Note { get; set; }
        public virtual ICollection<Publishing> Publishings{ get; set; }
    }
}