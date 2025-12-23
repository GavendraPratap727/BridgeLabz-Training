using System;
class PowerOfNumber{
	static void Main(String []args){
		Console.WriteLine("Enter a number");
		int a=int.Parse(Console.ReadLine()); //input a number
		Console.WriteLine("Enter a power");
		int pow=int.Parse(Console.ReadLine()); //input pow of the number
		int res=1;
		for(int i=1;i<=pow;i++){ //use for loop to find the result 
			res*=a;
			
		}
		
		Console.WriteLine("The result is "+res);
		
	}
}