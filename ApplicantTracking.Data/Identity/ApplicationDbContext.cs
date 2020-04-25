using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ApplicantTracking.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ApplicantTracking.Data.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
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
