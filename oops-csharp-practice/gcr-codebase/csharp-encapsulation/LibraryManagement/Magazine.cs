using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.LibraryManagement
{
    class Magazine : LibraryItem, IReservable
    {
        private string issueDate;
        private bool isAvailable;

        public string IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        public Magazine(int id, string title, string author, string issue)
            : base(id, title, author)
        {
            issueDate = issue;
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem(string borrowerName)
        {
            if (isAvailable)
            {
                isAvailable = false;
                BorrowerData = borrowerName;
                Console.WriteLine("Magazine reserved for " + borrowerName);
            }
            else
            {
                Console.WriteLine("Magazine already reserved");
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }

    }
}
