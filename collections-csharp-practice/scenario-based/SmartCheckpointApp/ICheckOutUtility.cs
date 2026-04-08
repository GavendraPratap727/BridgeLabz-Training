using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Senario.SmartCheckpointApp
{
    interface ICheckoutUtility
    {
        void AddCustomer(string name);
        void RemoveCustomer();
        void ProcessCheckout();
    }

}
