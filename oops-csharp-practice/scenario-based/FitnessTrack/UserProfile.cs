using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.FitnessTrack
{
    class UserProfile
    {
        public string Username;
        public int Age;
        public UserProfile(string username,int age) {
            Age = age;
            Username= username;
        }
    }
}
