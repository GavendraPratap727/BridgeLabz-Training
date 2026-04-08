using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.VehicalRent
{
    class Vehical
    {
        public string vehicalName;
        public double rentPerDay;
        public virtual double CalculateRent(int days)
        {
            return rentPerDay * days;
        }
        public virtual void ShowVehical()
        {
            Console.WriteLine("Vehical Name: " + vehicalName);
            Console.WriteLine("Rent Per Day: " + rentPerDay);
        }

    }
}
