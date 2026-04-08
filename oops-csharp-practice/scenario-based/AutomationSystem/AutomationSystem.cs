using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.AutomationSystem
{
     class AutomationSystem
    {
        static void Main(String[] args) {
            Appilance[] devices = { new Light("BedRoom Light"), new Fan("Ceiling Fan"), new AC("BeadRoom Ac") };
            foreach(Appilance device in devices) {
                device.TurnOn();
                device.TurnOff();
                Console.WriteLine();
            }
        }
    }
}
