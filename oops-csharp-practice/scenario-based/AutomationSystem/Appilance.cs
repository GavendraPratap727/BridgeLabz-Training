using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.AutomationSystem
{
    internal abstract  class Appilance:IControllable
    {
        public string Name;
        public Appilance(string name) {
            Name = name;
        }
        public abstract void TurnOn();
        public void TurnOff() { 
            Console.WriteLine($"{Name} is turned off");
        }

    }
}
