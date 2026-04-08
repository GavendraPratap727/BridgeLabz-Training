using System;
class Calculator{
	static void Main(String []args){
		
		Console.WriteLine("Enter first number"); //Enter first number
		float number1=float.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second number");
		float number2=float.Parse(Console.ReadLine()); //input second number
		float add=number1+number2; //addition
		float sub=number1-number2; //substraction
		float mul=number1*number2; //Multiply
		float div=number1/number2; //Divide
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+ number1+" and "+number2+" is "+add+" , "+ sub +" , "+mul+" , "+div);
		
		
		
	}
	
}