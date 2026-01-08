using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bridge.Opps_senario.AutomationSystem
{
    internal class AC:Appilance
    {
        public AC(string name) : base(name) { }
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is turned on at 16 degree");

        }
    }
}
