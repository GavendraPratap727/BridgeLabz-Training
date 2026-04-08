using System;
class ReverseCounterByForLoop{
	static void Main(String[]args){
		Console.Write("Enter a number to Start the counter ");
		int counter=int.Parse(Console.ReadLine()); //take input to start the counter
		for(int i=counter;i>=1;i--){ //for loop
			Console.WriteLine(i);
			
		}
	}
}