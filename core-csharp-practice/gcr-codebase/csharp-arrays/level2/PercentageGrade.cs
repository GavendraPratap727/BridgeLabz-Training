using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{

    class PercentageGrade
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter number of students ");
            int n = int.Parse(Console.ReadLine());
            int[] phy = new int[n];
            int[] chem = new int[n];
            int[] maths = new int[n];
            double[] per = new double[n];
            char[] grade = new char[n];
            // Input marks
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the marks of the students "+(i+1));
                Console.Write("Physics marks ");
                phy[i] = int.Parse(Console.ReadLine());
                if (phy[i] < 0) { i--;
                    continue; }
                Console.Write("Chemistry marks ");
                chem[i] = int.Parse(Console.ReadLine());
                if (chem[i] < 0) { i--; continue; }

                Console.Write("Maths marks ");
                maths[i] = int.Parse(Console.ReadLine());
                if (maths[i] < 0) { i--; continue; }

                // Calculate percentage by /3
                per[i] = (phy[i] + chem[i] + maths[i]) / 3.0;
                //  grade
                if (per[i] >= 80) grade[i] = 'A';
                else if (per[i] >= 70) grade[i] = 'B';
                else if (per[i] >= 60) grade[i] = 'C';
                else if (per[i] >= 50) grade[i] = 'D';
                else if (per[i] >= 40) grade[i] = 'E';
                else grade[i] = 'R';
            }
            
            for (int i = 0; i < n; i++) //result
            {
                Console.WriteLine($" Physics={phy[i]}, Chemistry={chem[i]}, Maths={maths[i]}, Percentage={per[i]}, Grade={grade[i]}");
            }
        }
    }

}

