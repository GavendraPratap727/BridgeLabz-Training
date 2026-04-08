//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bridge.Method.lvl2
//{
//  class LeapYearProgram
//    {
        
//        static bool IsLeapYear(int year)
//        {
            
//            if (year < 1582)  return false;
//            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) return true;
//            return false;
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("Enter a year ");
//            int year = int.Parse(Console.ReadLine());
//            bool res = IsLeapYear(year);
//            if (res)
//                Console.WriteLine(" Leap Year");
//            else
//                Console.WriteLine(" not a Leap Year");
//        }
//    }

//}
