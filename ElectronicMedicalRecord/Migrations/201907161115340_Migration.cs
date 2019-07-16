namespace ElectronicMedicalRecord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employeds",
                c => new
                    {
                        EmployedID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        UCIN = c.String(),
                        LicenseNumber = c.String(),
                        DateOfEmployment = c.DateTime(nullable: false),
                        SecurityQuestion = c.String(),
                        SecurityAnswer = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        HospitalID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployedID)
                .ForeignKey("dbo.Hospitals", t => t.HospitalID, cascadeDelete: true)
                .Index(t => t.HospitalID);
            
            CreateTable(
                "dbo.MedicalExaminations",
                c => new
                    {
                        EmployedID = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                        MedicalExaminationID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.MedicalExaminationID)
                .ForeignKey("dbo.Employeds", t => t.EmployedID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.EmployedID)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Publishings",
                c => new
                    {
                        DoctorID = c.Int(),
                        MedicalCertificatesID = c.Int(),
                        PrescriptionID = c.Int(),
                        PublishingID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Employed_EmployedID = c.Int(),
                        MedicalExamination_MedicalExaminationID = c.Int(),
                    })
                .PrimaryKey(t => t.PublishingID)
                .ForeignKey("dbo.Employeds", t => t.Employed_EmployedID)
                .ForeignKey("dbo.MedicalCertificates", t => t.MedicalCertificatesID)
                .ForeignKey("dbo.Prescriptions", t => t.PrescriptionID)
                .ForeignKey("dbo.MedicalExaminations", t => t.MedicalExamination_MedicalExaminationID)
                .Index(t => t.MedicalCertificatesID)
                .Index(t => t.PrescriptionID)
                .Index(t => t.Employed_EmployedID)
                .Index(t => t.MedicalExamination_MedicalExaminationID);
            
            CreateTable(
                "dbo.MedicalCertificates",
                c => new
                    {
                        MedicalCertificatesID = c.Int(nullable: false, identity: true),
                        Purpose = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.MedicalCertificatesID);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionID = c.Int(nullable: false, identity: true),
                        Dose = c.Double(nullable: false),
                        Drug = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.PrescriptionID);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        HospitalID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.HospitalID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        UCIN = c.String(),
                        HealthInsuranceNumber = c.String(),
                        Sex = c.String(),
                    })
                .PrimaryKey(t => t.PatientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MedicalExaminations", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Employeds", "HospitalID", "dbo.Hospitals");
            DropForeignKey("dbo.MedicalExaminations", "EmployedID", "dbo.Employeds");
            DropForeignKey("dbo.Publishings", "MedicalExamination_MedicalExaminationID", "dbo.MedicalExaminations");
            DropForeignKey("dbo.Publishings", "PrescriptionID", "dbo.Prescriptions");
            DropForeignKey("dbo.Publishings", "MedicalCertificatesID", "dbo.MedicalCertificates");
            DropForeignKey("dbo.Publishings", "Employed_EmployedID", "dbo.Employeds");
            DropIndex("dbo.Publishings", new[] { "MedicalExamination_MedicalExaminationID" });
            DropIndex("dbo.Publishings", new[] { "Employed_EmployedID" });
            DropIndex("dbo.Publishings", new[] { "PrescriptionID" });
            DropIndex("dbo.Publishings", new[] { "MedicalCertificatesID" });
            DropIndex("dbo.MedicalExaminations", new[] { "PatientID" });
            DropIndex("dbo.MedicalExaminations", new[] { "EmployedID" });
            DropIndex("dbo.Employeds", new[] { "HospitalID" });
            DropTable("dbo.Patients");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.MedicalCertificates");
            DropTable("dbo.Publishings");
            DropTable("dbo.MedicalExaminations");
            DropTable("dbo.Employeds");
        }
    }
}
