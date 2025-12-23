using System;
class BmiOfPerson{
	static void Main(String []args){
		Console.WriteLine("Enter your weight(kg) and height(cm)");
		double weight=double.Parse(Console.ReadLine()); //input the weight
		double hcm=double.Parse(Console.ReadLine()); // input the height
		double hm=hcm/100;
		double bmi=weight/(hm*hm); //cal bmi
		Console.WriteLine("Your Bmi is "+bmi);
		if(bmi<=18.4){
			Console.WriteLine("Your are UnderWeight");
		}
		else if(bmi>=18.5&&bmi<=24.9) Console.WriteLine("Your are Normal");
		else if(bmi>=25&&bmi<=39.9) Console.WriteLine("Your are OverWieght");
		else Console.WriteLine("Your are Obese");
		
		
		
		
	}
}