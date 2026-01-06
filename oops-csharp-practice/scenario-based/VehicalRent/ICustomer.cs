using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.VehicalRent
{
    interface ICustomer
    {
        void ShowCustomer();
    }
    class Customer : ICustomer
    {
        string name;
        public Customer(string name)
        {
            this.name = name;
        }
        public void ShowCustomer()
        {
            Console.WriteLine("Customer Name: " + name);
        }
    }
}
