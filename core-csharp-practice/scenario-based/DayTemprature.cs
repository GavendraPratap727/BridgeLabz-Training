//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bridge.Senario
//{
//    internal class DayTemprature
//    {
//        public static void TempratureOperationMenu(float[,] temp)
//        {
//            while (true)
//            {
//                Console.WriteLine("CHOOSE THE OPERATION U WANT TO PERFORM");
//                Console.WriteLine("PRESS 1: TO FIND AVERAGE OF EACH DAY IN A WEEK");
//                Console.WriteLine("PRESS 2: TO FIND THE HOTEST AND COLDEST DAY OF A WEEK");
//                Console.WriteLine("PRESS 3: FOR EXIT");
//                int op = int.Parse(Console.ReadLine()); //using swich case to check which method need to call
//                switch (op)
//                {
//                    case 1:
//                        AverageTemprature(temp);
//                        break;
//                    case 2:
//                        HotestAndColdestDay(temp);
//                        break;
//                    case 3:
//                        return;
//                    default:
//                        Console.WriteLine("INVALID OPERATION");
//                        break;
//                }
//            }
//        }
//        static void AverageTemprature(float[,] temp)  //method to find the avg temprature of each day
//        {
//            for (int i = 0; i < 7; i++) {
//                float sum = 0;
//                for (int j = 0; j < 24; j++) { 
//                    sum+= temp[i, j];
//                }
//                float avg= sum / 24;
//                Console.WriteLine("day " + (i + 1) + "avg temprature is " + avg);
//            }
//        }
//        public static void HotestAndColdestDay(float[,] temp) {  //method to find the hotest and coldest day
//            float hotavg = 0;
//            float coldavg = 0;
//            float hotday = 1;
//            float coldday = 1;
//            for (int j = 0; j < 24; j++) {
//                hotavg += temp[0, j];
//                coldavg += temp[0, j];
//            }
//            hotavg /= 24;
//            coldavg /= 24;
//            for (int i = 1; i < 7; i++) {
//                float sum = 0;
//                for (int j = 0; j < 24; j++) {
//                    sum += temp[i, j];
//                }
//                float avg = sum / 24;
//                if(avg> hotavg) {
//                    hotavg = avg;
//                    hotday = i+1;
//                }
//                if(avg< coldavg) {
//                    coldavg = avg;
//                    coldday = i+1;
//                }

//            }
//            Console.WriteLine("hottest day is " + hotday + " with avg temp of " + hotavg);
//            Console.WriteLine("coldest day is " + coldday + " with avg temp of " + coldavg);
//        }
//        static void Main(String[] args)
//        {
//            //temp of each day and hour
//            float[,] temp ={   
//                { 30,31,32,33,34,35,36,37,38,39,40,41,42,41,40,39,38,37,36,35,34,33,32,31},
//                { 28,29,30,31,32,33,34,35,36,37,38,39,40,39,38,37,36,35,34,33,32,31,30,29},
//                { 26,27,28,29,30,31,32,33,34,35,36,37,38,37,36,35,34,33,32,31,30,29,28,27},
//                { 25,26,27,28,29,30,31,32,33,34,35,36,37,36,35,34,33,32,31,30,29,28,27,26},
//                { 27,28,29,30,31,32,33,34,35,36,37,38,39,38,37,36,35,34,33,32,31,30,29,28},
//                { 29,30,31,32,33,34,35,36,37,38,39,40,41,40,39,38,37,36,35,34,33,32,31,30},
//                { 24,25,26,27,28,29,30,31,32,33,34,35,36,35,34,33,32,31,30,29,28,27,26,25}
//            };
//            TempratureOperationMenu(temp); //calling menu function

//        }

//    }
//}
