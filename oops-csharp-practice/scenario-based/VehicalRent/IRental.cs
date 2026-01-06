using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.VehicalRent
{
    interface IRental
    {
        double CalculateRent(int days);
        void ShowVehical();
    }
}
