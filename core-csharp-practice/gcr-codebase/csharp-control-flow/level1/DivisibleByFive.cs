using System;
class DivisibleByFive{
	static void Main(String []args){
		Console.WriteLine("Enter the number");
		int number=int.Parse(Console.ReadLine()); //Input an intiger number to check  if it is divisible by 5 or not
		
		Console.Write("Is the number "+number+" divisible by 5? ");
		if(number%5==0) Console.Write("Yes");
		else Console.Write("No");
		
	}
}