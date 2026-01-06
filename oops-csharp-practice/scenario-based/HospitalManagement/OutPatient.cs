using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.HospitalManagement
{
     class OutPatient : Patient,IPay
    {
        public double fee;
        public double CalculateBill() {
            return fee;
        }
        public override void Display()
        {
            Console.WriteLine("OutPatient Details:");
            base.Display();
            Console.WriteLine("Fees "+ CalculateBill());
        }

    }
}
