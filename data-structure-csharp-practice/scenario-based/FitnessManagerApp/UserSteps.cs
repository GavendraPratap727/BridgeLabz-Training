using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.FitnessManagerApp
{
    class UserSteps
    {
        private string userName;
        private int steps;
        public UserSteps(string userName, int steps)
        {
            this.userName = userName;
            this.steps = steps;
        }
        public string GetUserName()
        {
            return userName;
        }

        public int GetSteps()
        {
            return steps;
        }
    }
}
