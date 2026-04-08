using System;
class RemainderAndQuotient{
	static void Main(String []args){
		Console.WriteLine("Enter your first number");
		double number1=double.Parse(Console.ReadLine()); //Input first number
		Console.WriteLine("Enter your secondnumber");
		double number2=double.Parse(Console.ReadLine()); //input second number
		double 	quotient=number1%number2;//way to find Quotient use % operator
		double remainder=number1/number2;// way to find Remainder by using / operator
		Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+number1+" and "+number2);
		
	}
}