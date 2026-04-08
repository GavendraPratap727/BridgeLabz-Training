using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.TrafficManager
{
    class Vehicle
    {
        private string carNumber;
        private Vehicle next;

        public Vehicle(string carNumber)
        {
            this.carNumber = carNumber;
            next = null;
        }

        public string CarNumber
        {
            get { return carNumber; }
        }

        public Vehicle Next
        {
            get { return next; }
            set { next = value; }
    }
    }
}
