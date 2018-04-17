using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Data.Repositores
{
    interface IApplicantRepository
    {
        IEnumerable<Applicant> GetApplicants();

        Applicant GetApplicant(int applicantId);

        void AddApplicant(Applicant newApplicant);

        void UpdateApplicant(Applicant applicant);

        void DeleteApplicant(int applicantId);
    }
}
