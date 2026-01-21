using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class InsurancePolicy
    {
        static HashSet<string> policyNumbers = new HashSet<string>();          // uniqueness
        static List<string> order = new List<string>();                        // insertion order
        static Dictionary<string, string> coverage = new Dictionary<string, string>();
        static Dictionary<string, DateTime> expiry = new Dictionary<string, DateTime>();

        static void Main()
        {
            // Adding policies
            AddPolicy("P101", "Health", DateTime.Now.AddDays(20));
            AddPolicy("P102", "Vehicle", DateTime.Now.AddDays(60));
            AddPolicy("P103", "Health", DateTime.Now.AddDays(10));
            AddPolicy("P101", "Health", DateTime.Now.AddDays(40)); // duplicate

            // 1️⃣ All unique policies (in insertion order)
            Console.WriteLine("\nAll Unique Policies:");
            foreach (string p in order)
                PrintPolicy(p);

            // 2️⃣ Policies expiring within next 30 days
            Console.WriteLine("\nPolicies Expiring Within 30 Days:");
            DateTime limit = DateTime.Now.AddDays(30);
            foreach (string p in policyNumbers)
            {
                if (expiry[p] <= limit)
                    PrintPolicy(p);
            }

            // 3️⃣ Policies with specific coverage
            Console.WriteLine("\nPolicies with Coverage Type: Health");
            foreach (string p in policyNumbers)
            {
                if (coverage[p] == "Health")
                    PrintPolicy(p);
            }
        }

        static void AddPolicy(string number, string type, DateTime exp)
        {
            if (policyNumbers.Add(number))
            {
                order.Add(number);
                coverage[number] = type;
                expiry[number] = exp;
            }
            else
            {
                Console.WriteLine("Duplicate policy found: " + number);
            }
        }

        static void PrintPolicy(string number)
        {
            Console.WriteLine(
                number + " | " +
                coverage[number] + " | " +
                expiry[number].ToShortDateString()
            );
        }
    }
}
