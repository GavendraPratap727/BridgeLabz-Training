using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario
{
    class BusDistanceTracker
    {
        static void StartBus() //method to start bus distance tracker
        {
            double totleDistance = 0;  //totle distance travel by user
            int stop = 1;
            while (true) {
                Console.Write("Enter distanc e to want too add to stop " + stop + " in km ");
                double dist=double.Parse(Console.ReadLine());
                totleDistance+= dist;
                Console.WriteLine("You want to stop y/n ");
                char choice=char.Parse(Console.ReadLine());
                if(choice=='y' || choice=='Y') {
     
                    break;
                }
                stop++;

            }
            Console.WriteLine("Totle distance travel = "+ totleDistance + " km");
        }
        //main method
        static void Main(String[] args) {
            StartBus();
        }
    }
}
