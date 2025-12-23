using System;
class FizzBuzz{
	static void Main(String[] args){
		Console.WriteLine("Enter a number");
		int n=int.Parse(Console.ReadLine()); //inpu a mu,ber
	if(n<=0){ //checked it is a natural number or not
		Console.WriteLine("Enter a natural number");
	return;
	}
	for(int i=0;i<=n;i++){
		if(i%3==0&& i%5==0)Console.WriteLine("FizzBuzz");
		 else if(i%3==0)Console.WriteLine("Fizz");
		else if(i%5==0)Console.WriteLine("Buzz");
		else Console.WriteLine(i);
		
		 
		
	}
	}
}