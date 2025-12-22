using System;
class Multiplication{
	static void Main(String []args){
		Console.WriteLine("Enter a number");
		int n=int.Parse(Console.ReadLine()); //input a number
		for(int i=6;i<=9;i++){ //for loop from 6 to 9
			Console.WriteLine(n+"*"+i+"="+(i*n)); 
		}
	}
}