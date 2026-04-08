using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.HospitalManagement
{
     class InPatient: Patient,IPay
    {
        public int room;
        public int days;
        public double charge;
        public double CalculateBill() {
        return days* charge;
        }
        public override void Display()
        {
            Console.WriteLine("InPatient Details:");
            base.Display();
            Console.WriteLine("Romm numver "+ room);
            Console.WriteLine("Bill " + CalculateBill());
        }

    }
}
