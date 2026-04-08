using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.LibraryManagement
{
    interface IReservable
    {
        
            void ReserveItem(string borrowerName);
            bool CheckAvailability();
        }
    
}
