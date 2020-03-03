using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ApplicantTracking.Data.Identity;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Data.Repositories
{
    public class ApplicantRepository : IApplicantRepository, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public ApplicantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Applicant GetApplicant(int applicantId)
        {
            return _context.Applicants.Find(applicantId);
        }

        public IEnumerable<Applicant> GetApplicants()
        {
            return _context.Applicants.ToList();
        }

        public void AddApplicant(Applicant newApplicant)
        {
            _context.Applicants.Add(newApplicant);
            _context.SaveChanges();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            _context.Entry(applicant).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteApplicant(Applicant applicant)
        {
            _context.Applicants.Remove(applicant);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
