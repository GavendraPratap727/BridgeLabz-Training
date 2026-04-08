using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.PassworkCrackerApp
{
   public  class Menu
    {
        ICrackerUtility util = new CrackerUtility();

        public void Start()
        {
            while (true)
            {
                System.Console.WriteLine("\n1 Enter Password");
                System.Console.WriteLine("2 Start Simulation");
                System.Console.WriteLine("3 Exit");

                int ch = int.Parse(System.Console.ReadLine());

                if (ch == 1)
                {
                    System.Console.Write("Enter password (use a,b,c,1,2 only): ");
                    util.SetPassword(System.Console.ReadLine());
                }
                else if (ch == 2)
                {
                    util.StartCrack();
                }
                else if (ch == 3)
                {
                    break;
                }
            }
        }
    }

}
