using System;
class SumOfNumberUntilZero{
	static void Main(String [] args){
		Console.WriteLine("Enter the number and for stop the program press 0");
		double val=double.Parse(Console.ReadLine());
		double tot=0.0;
		while(val!=0){
			tot+=val;
			val=double.Parse(Console.ReadLine());
		}
		Console.WriteLine("The totle of these number is "+tot);
	}
}