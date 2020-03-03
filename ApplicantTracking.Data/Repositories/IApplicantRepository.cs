using System.Collections.Generic;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Data.Repositories
{
    public interface IApplicantRepository
    {
        IEnumerable<Applicant> GetApplicants();

        Applicant GetApplicant(int applicantId);

        void AddApplicant(Applicant newApplicant);

        void UpdateApplicant(Applicant applicant);

        void DeleteApplicant(Applicant applicant);
    }
}
