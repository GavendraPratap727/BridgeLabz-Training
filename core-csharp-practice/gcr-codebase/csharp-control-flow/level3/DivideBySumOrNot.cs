using System;
class DivideBySumOrNot{
	static void Main(String[]args){
		Console.WriteLine("Enter a positive number to find it is divisible by the sum of its digit or not");
		int n=int.Parse(Console.ReadLine()); //input a number
		int temp=n;
			int sum=0;
			
			while(n!=0){ //find the sum of digit in this number
				int rem=n%10;
				sum+=rem;
				n=n/10;
			}
			if(temp%sum==0)Console.WriteLine("yes it is divisible");  //check weather it is divisible or not
			else Console.WriteLine("No it is divisible"); 
	}
}