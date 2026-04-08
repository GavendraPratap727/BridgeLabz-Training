using System;
class SumOfNNaturalNumberUntilZeroOrNegative{
	static void Main(String [] args){
		Console.WriteLine("Enter the number and for stop the program press 0 or any negative number");
		double val=double.Parse(Console.ReadLine());
		double tot=0.0;
		while(true){
			if(val<=0)break;
			tot+=val;
			val=double.Parse(Console.ReadLine());
			
			
		}
		Console.WriteLine("The totle of these number is "+tot);
	}
}