using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VehicalRentalSystem
{
    

        public class Bike : Vehicle, IInsurable
        {
            public override double CalculateRentalCost(int days)
            {
                return RentalRate * days;
            }

            public double calculateInsurance()
            {
                return 2000;
            }

            public string getInsuranceDetails()
            {
                return "Bike Insurance Policy";
            }
        }
    }

