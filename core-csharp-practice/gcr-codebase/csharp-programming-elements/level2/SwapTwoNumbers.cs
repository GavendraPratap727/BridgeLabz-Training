using System;
class SwapTwoNumbers{
	static void Main(String []args){
		Console.WriteLine("Enter first number");
		int number1=int.Parse(Console.ReadLine()); //input first number
		Console.WriteLine("Enter second number");
		int number2=int.Parse(Console.ReadLine()); //input second number
		
		//Swapping w/o using extra variable
		
		number1=number1+number2; //add both and store in number 1
		number2=number1-number2; // sub num1 to num 2 to swap the value and store in num2
		number1=number1-number2; //// sub num1 to num 2 to swap the value and store n num1
		Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
		
	}
}