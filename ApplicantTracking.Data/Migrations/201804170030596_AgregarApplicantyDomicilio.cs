namespace ApplicantTracking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarApplicantyDomicilio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applicant",
                c => new
                    {
                        ApplicantId = c.Int(nullable: false, identity: true),
                        ApellidoParterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Nombre = c.String(),
                        FechaNacimiento = c.DateTime(),
                        DomicilioId = c.Int(),
                        Nacionalidad = c.String(),
                        Rfc = c.String(),
                        Curp = c.String(),
                    })
                .PrimaryKey(t => t.ApplicantId)
                .ForeignKey("dbo.Domicilio", t => t.DomicilioId)
                .Index(t => t.DomicilioId);
            
            CreateTable(
                "dbo.Domicilio",
                c => new
                    {
                        DomicilioId = c.Int(nullable: false, identity: true),
                        Calle = c.String(),
                        NumeroInterior = c.String(),
                        NumeroExterior = c.String(),
                        EntreCalles = c.String(),
                        Colonia = c.String(),
                        CodigoPostal = c.String(),
                    })
                .PrimaryKey(t => t.DomicilioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applicant", "DomicilioId", "dbo.Domicilio");
            DropIndex("dbo.Applicant", new[] { "DomicilioId" });
            DropTable("dbo.Domicilio");
            DropTable("dbo.Applicant");
        }
    }
}
