using System;

namespace bridge.kuch_bhi
{
    using System;

    class FizzBuzz
    {
        static void Main(String[] args )
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());  //input a number

            if (n <= 0)
            {
                Console.WriteLine("Number must be positive.");
                return;
            }

            string[] val = new string[n + 1];
            for (int i = 1; i <= n; i++) //store result in array
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    val[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    val[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    val[i] = "Buzz";
                }
                else
                {
                    val[i] = i.ToString();
                }
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Position " + i + " = " + val[i]);
            }
        }
    }

}

