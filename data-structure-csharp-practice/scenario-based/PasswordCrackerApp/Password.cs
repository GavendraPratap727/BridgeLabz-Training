using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.PassworkCrackerApp
{
    class Password
    {
        private char[] value;

        public Password(string p)
        {
            value = p.ToCharArray();
        }

        public char[] Get()
        {
            return value;
        }

        public int Length()
        {
            return value.Length;
        }
    }

}
