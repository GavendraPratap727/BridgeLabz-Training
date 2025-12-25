using System;
using System.Collections.Generic;
using System.Text;

namespace bridge.Method.lvl2
{
    class RandomNumber
    {
        public static int[] FourDigit(int n)
        {
            int[] num = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                num[i] = r.Next(1000, 10000);
            }
            return num;
        }
        public static double[] MinMax(int[] n)
        {
            int min = n[0];
            int max = n[0];
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
                min = Math.Min(min, n[i]);
                max = Math.Max(max, n[i]);
            }

            double avg= (double)sum / n.Length;
            double[] res = { avg, min, max };

            return res;
        }

        static void Main(String[] args)
        {
            // Generate 5 random 4-digit numbers
            int[] randomNumbers = FourDigit(5);

            Console.WriteLine("Generated 4-digit random numbers");
            foreach (int num in randomNumbers)
            {
                Console.WriteLine(num + " ");
            }
            double[] res = MinMax(randomNumbers);
            Console.WriteLine("Average value: " + res[0]+ "Minimum value: " + res[1]+ "Maximum value: " + res[2]);
        }
    }
}
