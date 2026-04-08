using System;
class ConvertCentimeterIntoFeet{
	static void Main(String []args){
		Console.WriteLine("Enter the height in cm");
		double heightcm=double.Parse(Console.ReadLine()); //input height in cm
		double heightinch=heightcm/2.54; //convert cm to inch
		double feet=heightinch/12; //convert inch to feet
		Console.WriteLine("Your Height in cm is "+heightcm+"  while in feet is "+feet+" and inches is "+heightinch);
		
	}
}