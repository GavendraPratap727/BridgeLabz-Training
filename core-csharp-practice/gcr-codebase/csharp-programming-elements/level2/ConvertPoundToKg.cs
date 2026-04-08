using System;
class ConvertPoundToKg{
	static void Main(String[]args){
		Console.WriteLine("Enter the weight in pounds");
		double pound=double.Parse(Console.ReadLine()); //take input in pound
		double kg=pound/2.2; //1pound =2.2kg  so  kg =pound/2.2 
		Console.WriteLine(" The weight of the person in pounds is "+pound+"  and in kg is "+kg);
		
	}
}