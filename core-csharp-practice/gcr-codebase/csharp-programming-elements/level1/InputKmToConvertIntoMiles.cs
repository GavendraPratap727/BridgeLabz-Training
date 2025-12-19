using System;
class ConvertKmIntoMiles{
	
	static void Main(String []args){
		Console.WriteLine("Enter the distance in Km"); 
		double km=double.Parse(Console.ReadLine()); //input km
		double miles=km*1.6; //convert to miles according to question 1km=1.6 miles
		Console.WriteLine("The distance "+km+"km in miles is "+miles);
		
	}
}