using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.AutomationSystem
{
    internal class Light:Appilance
    {
        public Light(string name) : base(name) { }
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is turned on");

        }
    }
}
