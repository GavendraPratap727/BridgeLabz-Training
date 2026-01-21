using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class VoitingSystem
    {
        static Dictionary<string, int> voteCount = new Dictionary<string, int>();

        // Maintains order of votes (LinkedHashMap behavior)
        static List<string> voteOrder = new List<string>();

        static void Main()
        {
            // Casting votes
            CastVote("Alice");
            CastVote("Bob");
            CastVote("Alice");
            CastVote("Charlie");
            CastVote("Bob");
            CastVote("Alice");

            // 1️⃣ Display votes in insertion order
            Console.WriteLine("Vote Order (LinkedHashMap behavior):");
            foreach (string v in voteOrder)
                Console.Write(v + " ");

            Console.WriteLine("\n");

            // 2️⃣ Display vote count (Dictionary)
            Console.WriteLine("Vote Count:");
            foreach (var v in voteCount)
                Console.WriteLine(v.Key + " : " + v.Value);

            // 3️⃣ Display sorted results (SortedDictionary)
            SortedDictionary<string, int> sortedResults =
                new SortedDictionary<string, int>(voteCount);

            Console.WriteLine("\nSorted Results:");
            foreach (var v in sortedResults)
                Console.WriteLine(v.Key + " : " + v.Value);
        }

        static void CastVote(string candidate)
        {
            voteOrder.Add(candidate);

            if (voteCount.ContainsKey(candidate))
                voteCount[candidate]++;
            else
                voteCount[candidate] = 1;
        }
    }
}
