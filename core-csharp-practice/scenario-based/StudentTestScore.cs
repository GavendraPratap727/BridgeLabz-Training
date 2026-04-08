using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Senario
{
     class StudentTestScore
    {
        //method to display menu and call the other methods
        static void StudentScoreCardManagerMenu(double[] score) {
            while (true) {
                Console.WriteLine("CHOOSE THE OPERATION U WANT TO PERFORM");
                Console.WriteLine("PRESS 1: TO FIND AVERAGE SCORE OF THE CLASS");
                Console.WriteLine("PRESS 2: TO FIND HIGHEST AND LOWEST SCORE IN THE CLASS");
                Console.WriteLine("PRESS 3: TO FIND THE SCORES THAT ARE ABOVE AVG");
                Console.WriteLine("PRESS 4: TO HANDLE INVALID SCORES(NEGATIVE OR NON NUMARIC)");
                Console.WriteLine("PRESS 5: FOR EXIT");
                int op = int.Parse(Console.ReadLine()); //using switch case to check which method need to call
                switch (op) {
                    case 1:
                        Console.WriteLine("Average of the class is "+AverageOfClass(score));
                        break;
                    case 2:
                        FindHigestAndLowerst(score);
                        break;
                        case 3:
                        ScoreAboveThanAverage(score);
                        break;
                    case 4:
                        HandleInvalidInput(score);
                        break;
                    
                    case 5:
                        return;
                    default:
                        Console.WriteLine("INVALID OPERATION");
                        break;
                }
            }
        }
        //method to print average of the class

        public static double AverageOfClass(double[] score) {
            double avg = 0.0;
            for (int i = 0; i < score.Length; i++)
            {
                avg += score[i];
            }
            avg /= score.Length;
            return avg;
        }
        //method to find the higest and the lowest marks
        public static void FindHigestAndLowerst(double[] score) {
            double high = 0.0;
            double low = double.MaxValue;
            for (int i = 0; i < score.Length; i++) { 
                if(score[i] > high) high= score[i];
                if (score[i]<low) low= score[i];
            }
            Console.WriteLine("Higest score is " + high + " Lowest Score is " + low);
        }
        //method to find the scores above than average
        public static void ScoreAboveThanAverage(double[] score) {
            double avg=AverageOfClass(score);
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] > avg) Console.WriteLine("The student "+(i+1)+" got his score " + score[i]+" is higher than average ("+avg+")");
            }
        }
        //method to handle invalid score input
        static void HandleInvalidInput(double[] score) {
            int min = 0;
            for(int i = 0; i < score.Length; i++)
            {
                if (!(score[i] >= min))
                {
                    Console.WriteLine($"You input invalid marks of this student {i + 1} Input marks greater than or equal to 0");
                }
            }
        }
        static void Main(String[] args) {
            Console.WriteLine("Enter the number of students ");
            int n=int.Parse(Console.ReadLine()); //input number of students
            double[]score=new double[n]; //array to store marks or number number of students
            Console.WriteLine("Enter the test scores of students "); 
            for(int i=0;i<n;i++) {
                score[i]=double.Parse(Console.ReadLine());
            }
            StudentScoreCardManagerMenu(score); //calling menu method
        }
    }
}
