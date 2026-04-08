using System;
class FindMultiple{
	static void Main(String[]args){
		Console.WriteLine("Enter a positive number");
		int n=int.Parse(Console.ReadLine()); // input a number
		for(int i=100;i>=1;i--){ //use loop accoding to Q
			if(i%n==0)  Console.WriteLine(i);
		}
	}
}