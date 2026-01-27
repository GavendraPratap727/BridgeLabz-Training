using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
    static void Main()
    {
        Console.Write("Enter a text containing SSN: ");
        string input = Console.ReadLine();

        string pattern = @"\d{3}-\d{2}-\d{4}";

        // Checking SSN using regex
        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine($" \"{match.Value}\" is valid");
        }
        else
        {
            Console.WriteLine(" SSN is invalid");
        }
    }
}
