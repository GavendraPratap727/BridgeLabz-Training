using System;
class TempratureFahrenheitToCelsius{
	static void Main(String []args){
		Console.WriteLine("Enter the temprature in Fahrenheit");
		double fah=double.Parse(Console.ReadLine()); //input the fahrenheit value
		double cel=(fah-32)*(5.0/9.0); //formula to convert fahrenheit to celsius
		Console.WriteLine("The "+fah+" Fahrenheit is  " +cel+"  Celsius");
		
		
	}
}