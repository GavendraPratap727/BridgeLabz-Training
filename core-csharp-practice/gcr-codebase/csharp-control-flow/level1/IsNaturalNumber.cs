using System;
class IsNaturalNumber{
	static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int a=int.Parse(Console.ReadLine()); //input a number
		if(a<=0){ //check if it a natural number or not
			Console.Write("The number "+a+" is not a natural number");
		}
		else{
			int sum=a*(a+1)/2;
			Console.WriteLine("The sum of  "+a+" natural number is "+sum);
		}
	}
}