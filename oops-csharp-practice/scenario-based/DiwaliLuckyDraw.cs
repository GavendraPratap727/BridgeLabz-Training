using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario
{
     class DiwaliLuckyDraw
    {
        //method for lucky draw
        static void StartLuckyDraw() {
            Random r=new Random(); 
            while (true)
            {
                Console.WriteLine("PRESS 1:FOR LUCKY DRAW");
                Console.WriteLine("PRESS 2:EXIT");
                int op = int.Parse(Console.ReadLine()); // User input for option
                if (op == 0)
                {
                    return;

                }
                if (op != 1)
                {
                    Console.WriteLine("INVALID OPTION");
                    continue;
                }
                int luckyNumber = r.Next(1, 101); // Generating random lucky number between 1 and 100
                Console.WriteLine($"You draw number {luckyNumber} ");
                if (luckyNumber % 3 == 0 && luckyNumber % 5 == 0) Console.WriteLine("CONGRATS YOU WON A PRICE");
                else Console.WriteLine("SORRY BETTER LUCK NEXT TIME");
            }
                
               
        }
        static void Main(String[] args) {
            StartLuckyDraw(); //call lucky draw method
        }
    }
}
