using System;
class CanVoteOrNot{
	static void Main(String []args){
		Console.WriteLine("Enter your age");
		int age=int.Parse(Console.ReadLine());
		if(age>=18)Console.WriteLine("The person's age is "+age+" and can vote.");
		else Console.WriteLine("The person's age is "+age+" and cannot vote.");
		
	}
}