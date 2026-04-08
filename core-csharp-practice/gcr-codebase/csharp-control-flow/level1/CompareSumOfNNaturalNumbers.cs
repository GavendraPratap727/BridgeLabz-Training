using System;
class CompareSumOfNNaturalNumbers{
	static void Main(String[]args){
		Console.WriteLine("Enter a number");
		int num=int.Parse(Console.ReadLine()); //input a number
		if(num<=0){ //check if number is narutal or not
			Console.WriteLine("The number " +num+" is not a natural number.");
		}
		else{
			int sum_by_formula=num*(num+1)/2; //cal sum by formula
			int sum_by_loop=0;
			int temp=num;
			while(num>0){  //cal sum by loop
				sum_by_loop+=num;
				num-=1;	
			}
			Console.WriteLine("Sum by formula "+sum_by_formula);
			Console.WriteLine("Sum by loop "+sum_by_loop);
			if(sum_by_formula==sum_by_loop)Console.WriteLine("Both are equal"); //check if both sum equal or not
			else  Console.WriteLine("Both are not equal");
		}
	}
}