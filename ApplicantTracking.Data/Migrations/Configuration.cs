using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ApplicantTracking.Data.Identity;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ApplicantTracking.Data.Identity.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var applicants = new List<Applicant>()
            {
                new Applicant() { Nombre = "Felipe", ApellidoParterno = "Romero", Rfc = "FRRO0123456789", Nacionalidad = "Mexicano" },
                new Applicant() { Nombre = "Jesica", ApellidoParterno = "Angulo", Rfc = "JANA012345671", Nacionalidad = "Mexicana" },
                new Applicant() { Nombre = "Francisco", ApellidoParterno = "Montes", Rfc = "FRMO0123456789", Nacionalidad = "Mexicano" },
                new Applicant() { Nombre = "Carla", ApellidoParterno = "Medina", Rfc = "CALA0123456789", Nacionalidad = "Mexicana" }
            };

            foreach (var applicant in applicants)
            {
                context.Applicants.AddOrUpdate(a => a.Nombre, applicant);
            }

        }
    }
}
