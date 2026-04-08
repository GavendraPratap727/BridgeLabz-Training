using System;
class Factorial{
	static void Main(String []args){
		Console.WriteLine("Enter a number"); 
		int n=int.Parse(Console.ReadLine()); //input a number 
		int fac=1;
		if(n<0){Console.WriteLine("Enter natural number"); //check if the number is natural or not
		return;
		}
		for(int i=1;i<=n;i++){  //using loop ittrate from i=1 to n
			fac*=i;
		}	
		Console.WriteLine("The Factorial of the number is"+fac);
	}
}