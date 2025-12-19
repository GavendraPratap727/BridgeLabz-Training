using System;
class SimpleIntrest{
	static void Main(String []args){
		Console.WriteLine("Enter the Value of Principle");
		double principle=double.Parse(Console.ReadLine()); //Input the Principle value
		Console.WriteLine("Enter the rate of intrest");
		double rate=double.Parse(Console.ReadLine()); //Input the rate
		Console.WriteLine("Enter the time in years");
		double time=double.Parse(Console.ReadLine()); //Input the time in years
		double si=(principle*rate*time)/100; //simple intrestformula p*r*t/100 
		Console.WriteLine("The Simple Interest is "+si+" for Principal "+principle+" Rate of Interest "+rate+" and Time "+time); 
		
		
		
	}
}