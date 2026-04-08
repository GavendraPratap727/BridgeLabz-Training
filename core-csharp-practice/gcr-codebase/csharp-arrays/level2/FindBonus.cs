using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class FindBonus
    {
        static void Main(String[] args) { 
            Console.WriteLine("Enter the number of employees");
            int n=int.Parse(Console.ReadLine()); //input number of employee

            double[] salary= new double[n]; //create 4 arrays to store salary year bounus and new salo of every emp
            double[] year = new double[n];
            double[] bonus= new double[n];
            double[] newsalary = new double[n];
            double totb = 0.0; //to store totle bonus
            double totold = 0.0; //to store totle old salary;
            double totnew = 0.0; //to store totle new salary
            for (int i = 0; i < n; i++) { 
                Console.WriteLine("Employee " + (i + 1));
                Console.Write("Enter salary ");
                salary[i]= double.Parse(Console.ReadLine());
                Console.Write("Enter year of service ");
                year[i] = double.Parse(Console.ReadLine());
                if (salary[i] <= 0 || year[i] < 0) {
                    Console.WriteLine("Invalid input");
                    i--;
                    continue;
                }

            }
            for (int i = 0; i < n; i++) {
                if (year[i] > 5) bonus[i] = salary[i]*0.05;
                else bonus[i]=0.002;
                newsalary[i] = salary[i] + bonus[i];
                totb+=bonus[i];
                totold+=salary[i];
                totnew+=newsalary[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee " + (i + 1) + " Old Salary: " + salary[i] + "  Bonus: " + bonus[i] + "  New Salary: " + newsalary[i]);
            }
            Console.WriteLine("Total Old Salary: " + totold + " Total Bonus: " + totb + " Total New Salary: " + totnew);






        }
    }
}
