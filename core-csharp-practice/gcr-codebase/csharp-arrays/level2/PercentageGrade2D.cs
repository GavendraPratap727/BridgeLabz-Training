using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
    

    class PercentageGrade2D
    {
        static void Main(String[]args)
        {
            Console.WriteLine("ENter the number of the students");
            int stu=   int.Parse(Console.ReadLine()); //input number of student
            int[,] mark = new int[stu, 3]; //declare a 2d array to store marks of students
            double[] per = new double[stu]; //to store percentage
            char[] gra = new char[stu]; //to store grade
            Console.WriteLine("Enter the marks of the students in Physics, Chemistry and Maths");
            for (int i = 0; i < stu; i++) {
                Console.WriteLine(" Student " + (i + 1));
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) Console.Write(" Physics marks ");
                    else if (j == 1) Console.Write(" Chemistry marks ");
                    else Console.Write(" Maths marks ");
                    mark[i,j]=int.Parse(Console.ReadLine());
                    if (mark[i, j] < 0) {  //check i fhe marks is greater than 0 or not
                        Console.WriteLine("Enter positive marks");
                        j--; 
                        continue;
                    }
                }
                per[i] = (mark[i, 0] + mark[i, 1] + mark[i, 2]) / 3.0;
                if (per[i]>=80) gra[i]='A';
                else if (per[i]>=70) gra[i]='B';
                else if (per[i]>=60) gra[i]='C';
                else if (per[i]>=50) gra[i]='D';
                else if (per[i]>=40) gra[i]='E';
                else gra[i]='R';
            }
            for (int i = 0; i < stu; i++) //print the answer
            {
                Console.WriteLine("Student " + (i + 1) + " Physics Marks   : " + mark[i, 0] + " Chemistry Marks : " + mark[i, 1] + " Maths Marks     : " + mark[i, 2] + " Percentage : " + per[i] + " Grade : " + gra[i]);
            }


        }
        }
    }


