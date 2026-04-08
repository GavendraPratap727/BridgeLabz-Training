using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Senario.HospitalSystemApp
{
    public class HospitalUnit
    {
        public string Name { get; private set; }
        public bool IsAvailable { get; set; }
        public HospitalUnit Next { get; set; }

        public HospitalUnit(string name)
        {
            Name = name;
            IsAvailable = true;
            Next = null;
        }
    }

}
