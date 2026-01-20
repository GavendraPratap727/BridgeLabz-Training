using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.PassworkCrackerApp
{
    interface ICrackerUtility
    {
        void SetPassword(string pwd);
        void StartCrack();
    }

}
