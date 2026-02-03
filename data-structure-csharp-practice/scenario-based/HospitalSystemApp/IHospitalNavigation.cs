using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Senario.HospitalSystemApp
{
    public interface IHospitalNavigation
    {
        void AddUnit(string name);
        void RemoveUnit(string name);
        void SetAvailability(string name, bool isAvailable);
        string FindNextAvailable(string startName);
        void DisplayRoute();
    }

}
