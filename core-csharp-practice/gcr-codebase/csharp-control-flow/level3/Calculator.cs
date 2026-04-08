using System;
class Calculator{
	static void Main(String[]args){
		Console.WriteLine("Enter first number");
		double first=double.Parse(Console.ReadLine()); //input 2 numbers and operator 
		Console.WriteLine("Enter second number");
		double second=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter operator (+, -, *, /)");
		string op=Console.ReadLine();
		switch(op) //using switch case to choose the operation according o the input
		{
			case "+" :
			Console.WriteLine("Result = "+(first+second));
			break;
			case "-" :
			Console.WriteLine("Result = "+(first-second));
			break;
			case "*" :
			Console.WriteLine("Result = "+(first*second));
			break;
			case "/" :
			if(second!=0)
			Console.WriteLine("Result = "+(first/second));
		else  Console.WriteLine("Divide by 0 not allowed");
			break;
			default:
			Console.WriteLine("Invalid operator");
			break;
			
			
		}
	}
}