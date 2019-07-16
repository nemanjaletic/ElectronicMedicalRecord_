using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class MedicalExamination
    {
        public int MedicalExaminationID { get; set; }
        [Column(Order = 0)]
        public int EmployedID { get; set; }
        [Column(Order = 1)]
        public int PatientID { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Publishing> Publishings { get; set; }
    }
}