using System;
class IsPositiveNegativeZero{
	static void Main(string[] args){
		Console.WriteLine("Enter a number to check weather it it negative positive or zero");
		int num=int.Parse(Console.ReadLine()); //iput a number to check weather it is negative positive or zero
		if(num>0) Console.WriteLine("Positive");
		else if(num<0)Console.WriteLine("Negative");
		else Console.WriteLine("Zero");
	}
}