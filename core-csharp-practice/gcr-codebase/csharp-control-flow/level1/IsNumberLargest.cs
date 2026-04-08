using System;
class IsNumberLargest{
	static void Main(String[] args){
		Console.WriteLine("Enter three number");
		int num1=int.Parse(Console.ReadLine());//input first number
		int num2=int.Parse(Console.ReadLine()); //input second number
		int num3=int.Parse(Console.ReadLine()); //input third number
		if(num1>num2&&num1>num3){ // check if num 1 is the largest
			Console.WriteLine("Is the first number the largest? Yes");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest? No");
			
			
			
		}
		else if(num2>num1 &&num2>num3){ // check if num 2 is the largest
			Console.WriteLine("Is the first number the largest? No");
			
			Console.WriteLine("Is the second number the largest? Yes");
			Console.WriteLine("Is the third number the largest? No");
			
			
		}
		else{ //// check if num 3 is the largest
			Console.WriteLine("Is the first number the largest? No");
			Console.WriteLine("Is the second number the largest? No");
			
			Console.WriteLine("Is the third number the largest? Yes");
			
			
		}
	}
}