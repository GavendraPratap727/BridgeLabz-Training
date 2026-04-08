using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.FitnessManagerApp
{
    class FitnessManagerImpl : IFitnessManager
    {
        private UserSteps[] users = new UserSteps[20]; 
        private int count = 0;

        public void AddUser(string name, int steps)
        {
            if (count >= users.Length)
            {
                Console.WriteLine("User limit reached");
                return;
            }

            users[count++] = new UserSteps(name, steps);
            Console.WriteLine("User added successfully");
        }
        public void SortBySteps()
        {
            if (count == 0)
            {
                Console.WriteLine("No data to sort");
                return;
            }
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (users[j].GetSteps() < users[j + 1].GetSteps())
                    {
                        UserSteps temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ranking updated using Bubble Sort");
        }

        public void DisplayRanking()
        {
            if (count == 0)
            {
                Console.WriteLine("No users available");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("--- Daily Step Ranking ---");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) + ". " + users[i].GetUserName() + " - " + users[i].GetSteps() + " steps");
            }
        }
    }
}
