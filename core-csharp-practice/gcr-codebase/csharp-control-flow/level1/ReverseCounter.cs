using System;
class ReverseCounter{
	static void Main(String []args){
		Console.WriteLine("Enter the number to start the counter");
		int num=int.Parse(Console.ReadLine()); //Enter a number to start the counter 
		while(num>=1){   //inside loop until num>=1
			Console.WriteLine(num);
			num-=1; //num=num-1
		}
	}
}