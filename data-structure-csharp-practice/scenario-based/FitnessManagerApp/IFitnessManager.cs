using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.FitnessManagerApp
{
    public interface IFitnessManager
    {
        void AddUser(string name, int steps);
        void SortBySteps();
        void DisplayRanking();
    }
}
