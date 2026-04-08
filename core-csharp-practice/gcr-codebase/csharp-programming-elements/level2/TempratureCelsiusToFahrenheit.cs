using System;
class TempratureCelsiusToFahrenheit{
	static void Main(String []args){
		Console.WriteLine("Enter the temprature in celsius");
		double cel=double.Parse(Console.ReadLine()); //input the celsius value
		double fah=(cel*(9.0/5.0))+32; //formula to convert celsius to fahrenheit
		Console.WriteLine("The "+cel+" Celsius is  " +fah+"  Fahrenheit");
		
		
	}
}