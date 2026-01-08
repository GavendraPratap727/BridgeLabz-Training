using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bridge.Opps_senario.AutomationSystem
{
    internal class Fan:Appilance
    {
        public Fan(string name) : base(name) { }
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is turned on in fast speed");

        }
    }
}
