using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.AdharCard
{
    interface IUtility
    {
        void Add(long aadhar);
        void Search(long aadhar);
        void Sort();
        void Display();
    }

}
