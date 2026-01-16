using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.AddressBook
{
    internal class Start
    {
        static void Main(String[]args)
        {
            Contacts c = new Contacts("love", "singh", "AMerplai", "mathura", "up", "202001", "7900220727", "pratapgavedra01@gmail.com");
            c.DisplayContact();
        }
    }
}
