using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    interface ITraffic
    {
        void AddCar(string carNo);
        void RemoveCar();
        void ShowRoundabout();
    }
}