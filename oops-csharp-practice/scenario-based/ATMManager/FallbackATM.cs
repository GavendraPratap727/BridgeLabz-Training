using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.ATMManager
{
    class FallbackATM : ATM
    {
        public FallbackATM() : base(new int[] { 50, 20 }) { }
    }

}
