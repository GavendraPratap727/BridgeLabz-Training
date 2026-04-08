using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.FitnessTrack
{
    internal class CardioWorkout:Workout
    {
        public CardioWorkout(string name, int duration) : base(name, duration)
        {
        }
        public override void StartWorkout()
        {
            Console.WriteLine("Start Workout " + WorkoutName);
        }
    }
}
