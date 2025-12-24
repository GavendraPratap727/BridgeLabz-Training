using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
    public class CanVoteOrNot
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter the age of all 10 students"); 
            int[] arr = new int[10]; //create a array of size 10 
            for (int i = 0; i < 10; i++) 
            {
                arr[i] = int.Parse(Console.ReadLine()); //enter the age of all the 10 stuents
            }  
            for (int i = 0; i < 10; i++) { //check weather the student can vote or not
                if (arr[i] >= 18) Console.WriteLine("The student with the age " + arr[i] + " Can Vote");
                else Console.WriteLine("The student with the age " + arr[i] + " Can not vote");
            }
        }
    }
}
