using System;
class CountDigit{
	static void Main(String[]args){
		Console.WriteLine("Enter a positive number to find no of digits");
		int n=int.Parse(Console.ReadLine()); //input a number
		
			int count=0;
			if(n==0)  Console.WriteLine("1 is a number of digits in this number");
			while(n!=0){ //find the digit in this number
				count++;
				n=n/10;
			}
			Console.WriteLine(count+" is a number of digits in this number"); 
			
	}
}