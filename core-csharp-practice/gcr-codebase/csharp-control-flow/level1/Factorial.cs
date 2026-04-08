using System;
class Factorial{
	static void Main(String []args){
		Console.WriteLine("Enter a number"); 
		int a=int.Parse(Console.ReadLine()); //input a number 
		int fac=1;
		while(a>=1){ //using while looop utnil a<1;
			fac*=a;  
			a--;
		}
		Console.WriteLine("The Factorial of the number is"+fac);
	}
}