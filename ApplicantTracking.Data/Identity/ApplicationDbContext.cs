using System;
using System.Data.Entity;
using System.Linq;
using ApplicantTracking.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ApplicantTracking.Data.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
