using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Senario
{
    class EduQuiz
    {
        // Array that stores the correct answers for all 10 questions
        static string[] correctAnswers = { "C", "B", "B", "C", "D", "C", "A", "D", "C", "C" };
        // Method to calculate and display result
        public static void Result(string[] studentAnswer)
        {
            Console.WriteLine("      Result            ");
            Console.WriteLine();
            int score = 0;
            for (int i = 0; i < 10; i++)
            {

                if (studentAnswer[i] == correctAnswers[i])
                {
                    Console.WriteLine($"Question {i + 1}  Correct");
                    score++;
                }
                else Console.WriteLine($"Question {i + 1}  Wrong");
            }
            Console.WriteLine($"Your total score is: {score}/10");

        }
        // Method to display questions and take user input
        public static void Questions()
        {
            // Array that stores all quiz questions
            string[] questions =
           {
                "1) Which language is used for .NET? \n A) Java \n B) Python \n C) C# \n D) PHP",
                "2) Which keyword is used to create object? \n A) class \n B) new \n C) this \n D) static",
                "3) Size of int in C#? \n A) 2 bytes \n B) 4 bytes \n C) 8 bytes \n D) Depends",
                "4) Which loop runs at least once? \n A) for \n B) while \n C) do-while \n D) foreach",
                "5) Which is not a data type? \n A) int \n B) float \n C) string \n D) loop",
                "6) Entry point of C# program? \n A) Start() \n B) Run() \n C) Main() \n D) Begin()",
                "7) Which symbol is used for inheritance? \n A) : \n B) ; \n C) # \n D) .",
                "8) Which is reference type? \n A) int \n B) double \n C) struct \n D) string",
                "9) Which access modifier is most restrictive? \n A) public \n B) protected \n C) private \n D) internal",
                "10) Which method prints output? \n A) Console.Read() \n B) Console.Write() \n C) Console.WriteLine() \n D) Console.Input()"
            };
            // Array to store student's answers
            string[] studentAnswers = new string[10];
            // Loop to display each question and take answer
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(questions[i]);
                Console.Write("Enter your answer (A/B/C/D): ");
                // Convert input to uppercase for comparison
                studentAnswers[i] = Console.ReadLine().ToUpper();
            }
            Console.WriteLine();
            Result(studentAnswers);


        }
        // Main method – entry point of the program
        static void Main(String[] args)
        {
            Questions();

        }
    }
}
