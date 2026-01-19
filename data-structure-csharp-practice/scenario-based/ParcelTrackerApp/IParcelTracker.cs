using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario
{
    interface IParcelTracker
    {
        void AddStage(string stage);
        void AddCheckpoint(string afterStage, string newStage);
        void TrackForward();
        void MarkLost(string stage);
    }
}
