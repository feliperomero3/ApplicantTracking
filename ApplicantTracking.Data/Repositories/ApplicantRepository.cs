using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicantTracking.Data.Identity;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Data.Repositores
{
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddApplicant(Applicant newApplicant)
        {
            throw new NotImplementedException();
        }

        public void DeleteApplicant(int applicantId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
