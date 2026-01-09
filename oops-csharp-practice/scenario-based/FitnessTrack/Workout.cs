using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.FitnessTrack
{
    internal abstract class Workout : ITrackable {

        public string WorkoutName;

        public int Duration;
        public Workout(string workoutName, int duration)
        {
            this.WorkoutName = workoutName; 
            this.Duration = duration;
        }
        public abstract void StartWorkout();
        public virtual void EndWorkout() {
            Console.WriteLine("You Complete Workout in " + Duration+" Minutes");
        }

    }
    
    
}
