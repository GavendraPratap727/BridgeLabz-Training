using bridge.Encapsulation.RideHandaling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VehicalRentalSystem
{
    public class Car : Vehicle, IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double calculateInsurance()
        {
            return 1000;
        }

        public string getInsuranceDetails()
        {
            return "Car Insurance Policy";
        }
    }

}
