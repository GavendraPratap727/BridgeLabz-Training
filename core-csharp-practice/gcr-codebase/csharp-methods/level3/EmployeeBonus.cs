using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
    class EmployeeBonus
    {
        static void Main()
        {
            double[,] data = getData();
            double[,] result = getBonus(data);

            showData(data, result);
        }

        static double[,] getData()
        {
            double[,] arr = new double[10, 2];
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                arr[i, 0] = r.Next(10000, 100000);
                arr[i, 1] = r.Next(1, 16);
            }

            return arr;
        }

        static double[,] getBonus(double[,] arr)
        {
            double[,] res = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                double salary = arr[i, 0];
                double years = arr[i, 1];
                double percent;

                if (years > 5)
                    percent = 5;
                else
                    percent = 2;

                double bonus = salary * percent / 100;
                double newSalary = salary + bonus;

                res[i, 0] = newSalary;
                res[i, 1] = bonus;
            }

            return res;
        }

        static void showData(double[,] data, double[,] res)
        {
            double oldTotal = 0;
            double bonusTotal = 0;
            double newTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Employee " + (i + 1));
                Console.WriteLine("Years of Service: " + data[i, 1]);
                Console.WriteLine("Old Salary: " + data[i, 0]);
                Console.WriteLine("Bonus: " + res[i, 1]);
                Console.WriteLine("New Salary: " + res[i, 0]);
                Console.WriteLine();

                oldTotal += data[i, 0];
                bonusTotal += res[i, 1];
                newTotal += res[i, 0];
            }

            Console.WriteLine("Final Summary");
            Console.WriteLine("Total Old Salary: " + oldTotal);
            Console.WriteLine("Total Bonus: " + bonusTotal);
            Console.WriteLine("Total New Salary: " + newTotal);
        }
    }

}
