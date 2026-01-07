using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.RideHandaling
{
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string location);
    }
}
