using ElectronicMedicalRecord.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ElectronicMedicalRecord
{
    public class ElectronicMedicalRecord_DbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Hospital> Hospitals{ get; set; }
        public DbSet<Employed> Employeds{ get; set; }
        public DbSet<Prescription> Prescriptions{ get; set; }
        public DbSet<MedicalCertificates> MedicalCertificates{ get; set; }
        public DbSet<MedicalExamination> MedicalExaminations{ get; set; }
        public DbSet<Publishing> Publishings{ get; set; }
    }
}