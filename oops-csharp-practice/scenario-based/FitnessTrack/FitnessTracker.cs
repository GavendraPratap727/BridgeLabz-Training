using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.FitnessTrack
{
    internal class FitnessTracker
    {
        static void Main(String[] args) {
            UserProfile up = new UserProfile("Gavendra",21);
            Workout[] wk = { new CardioWorkout("Running", 30), new StrengthWorkout("Weight Lifting", 50) };
            foreach (Workout work in wk) {
                work.StartWorkout();
                work.EndWorkout();
                Console.WriteLine();
            }

        }
    }
}
