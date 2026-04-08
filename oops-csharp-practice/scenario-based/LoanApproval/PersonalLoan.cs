using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.LoanApproval
{
    class PersonalLoan : LoanApplication
    {
        public PersonalLoan(Applicant applicant, int months) : base(applicant, months, 12.0)
        {
        }
    }

}
