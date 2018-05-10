using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicantTracking.Data.Identity;
using ApplicantTracking.Domain.Models;
using System.Data.Entity;

namespace ApplicantTracking.Data.Repositores
{
    public class ApplicantRepository : IApplicantRepository, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public ApplicantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddApplicant(Applicant newApplicant)
        {
            _context.Applicants.Add(newApplicant);
        }

        public void DeleteApplicant(int applicantId)
        {
            Applicant applicant = _context.Applicants.Find(applicantId);
            _context.Applicants.Remove(applicant);
        }

        public Applicant GetApplicant(int applicantId)
        {
            return _context.Applicants.Find(applicantId);
        }

        public IEnumerable<Applicant> GetApplicants()
        {
            return _context.Applicants.ToList();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            _context.Entry(applicant).State = EntityState.Modified;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public Applicant Find(int? id)
        {
            return _context.Applicants.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Remove(Applicant applicant)
        {
            _context.Applicants.Remove(applicant);
        }
    }
}
