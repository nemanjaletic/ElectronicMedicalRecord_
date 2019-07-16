using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord.Models
{
    public class MedicalExamination
    {
        public int MedicalExaminationID { get; set; }
        public int EmployedID { get; set; }
        public int HopitalID { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public string Note { get; set; }

    }
}