using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
    public class CanVote
    {
        public static bool CanStudentVote(int age)
        {
            if (age < 0) return false;
            if (age >= 18) return true;
            else return false;
        }
        static void Main(String[] args)
        {
            int[] ages = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter age  student " + (i + 1)+" ");
                ages[i] = int.Parse(Console.ReadLine());
                bool result = CanStudentVote(ages[i]);
                if (result) Console.WriteLine("Student " + (i + 1) + " can vote");
                else Console.WriteLine("Student " + (i + 1) + " cannot vote");
            }
        }
    }

}
