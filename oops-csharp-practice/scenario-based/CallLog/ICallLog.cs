using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CallLog
{
    interface ICallLog
    {
        void Display();
        string GetMessage();
        DateTime GetTime();
    }
}
