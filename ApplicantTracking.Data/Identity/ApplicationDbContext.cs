using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using ApplicantTracking.Data.Migrations;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Data.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
