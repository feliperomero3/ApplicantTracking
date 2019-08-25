using ApplicantTracking.Domain.Models;
using System.Collections.Generic;

namespace ApplicantTracking.Data.Repositories
{
    public interface IApplicantRepository
    {
        IEnumerable<Applicant> GetApplicants();

        Applicant GetApplicant(int applicantId);

        void AddApplicant(Applicant newApplicant);

        void UpdateApplicant(Applicant applicant);

        void DeleteApplicant(int applicantId);

        Applicant Find(int? id);

        void SaveChanges();

        void Remove(Applicant applicant);

        void Dispose();
    }
}
