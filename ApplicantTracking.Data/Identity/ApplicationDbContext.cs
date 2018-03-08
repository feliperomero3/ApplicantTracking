using System;
using System.Data.Entity;
using System.Linq;
using ApplicantTracking.Data.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ApplicantTracking.Data.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
