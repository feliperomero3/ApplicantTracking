using System;
using System.Data.Entity;
using System.Linq;
using ApplicantTracking.Data.Identity;

namespace ApplicantTracking.Data.Context
{
    public class ApplicantDbContext : ApplicationDbContext
    {


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }

    }
}
