using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class HospitalTrial
    {
        static void Main()
        {
            // PriorityQueue<PatientName, Priority>
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            // Adding patients (negative priority because PriorityQueue is min-heap)
            pq.Enqueue("John", -3);
            pq.Enqueue("Alice", -5);
            pq.Enqueue("Bob", -2);

            Console.WriteLine("Treatment Order:");

            while (pq.Count > 0)
            {
                string patient = pq.Dequeue();
                Console.WriteLine(patient);
            }
        }
    }
}
