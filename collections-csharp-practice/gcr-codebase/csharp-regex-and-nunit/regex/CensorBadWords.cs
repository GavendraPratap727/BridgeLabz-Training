using System;
using System.Text.RegularExpressions;

class CensorBadWords

{
    static void Main()
    {
        Console.Write("Enter the Sentence: ");
        string s = Console.ReadLine();
        string p = @"\b(damn|stupid|bitch|suyar|kutta)\b";

        string r = Regex.Replace(s, p, "****", RegexOptions.IgnoreCase);
        Console.WriteLine(r);
    }
}
