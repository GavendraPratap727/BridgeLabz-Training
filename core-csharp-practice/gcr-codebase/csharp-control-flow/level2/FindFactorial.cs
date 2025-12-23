using System;
class PowerOfNumber{
	static void Main(String[] args){
		Console.WriteLine("Enter a number to find its factorial");
		int num=int.Parse(Console.ReadLine()); //input a number 
		for(int i=2;i<=num/2;i++){ //find the factors
			if(num%i==0) Console.WriteLine("factor "+i);
		}
		Console.WriteLine("factor "+num);
	}
}