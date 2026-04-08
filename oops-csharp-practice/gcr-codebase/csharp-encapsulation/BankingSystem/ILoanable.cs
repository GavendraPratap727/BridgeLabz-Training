using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.BankingSystem
{
   
        public interface ILoanable
        {
            public void ApplyForLoan();

            public bool CalculateLoanEligibility(double amount);
        }
    }


