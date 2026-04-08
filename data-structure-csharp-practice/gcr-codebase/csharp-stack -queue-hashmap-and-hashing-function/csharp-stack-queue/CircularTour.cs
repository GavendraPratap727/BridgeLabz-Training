using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function
{
    class CircularTour
    {
        static void Main()
        {
            int[] petrol = { 6, 3, 7 };
            int[] distance = { 4, 6, 3 };
            int n = petrol.Length;
            Queue<int> tour = new Queue<int>();
            int start = 0;
            int currPetrol = 0;
            int i = 0;
            while (start < n)
            {
                currPetrol += petrol[i] - distance[i];
                tour.Enqueue(i);
                if (currPetrol < 0)
                {
                    while (tour.Count > 0)
                    {
                        int removed = tour.Dequeue();
                        currPetrol -= petrol[removed] - distance[removed];
                    }
                    start = start + 1;
                    i = start;
                    currPetrol = 0;
                    continue;
                }
                if (tour.Count == n)
                {
                    Console.WriteLine("Start at petrol pump index: " + start);
                    return;
                }
                i = (i + 1) % n;
            }
            Console.WriteLine("No possible circular tour");
        }
    }

}
