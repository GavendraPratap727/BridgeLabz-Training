using System;
class ArmstrongNumber{
	static void Main(String[]args){
		Console.WriteLine("Enter a number to check Armstrong or not");
		int n=int.Parse(Console.ReadLine()); //input a number
			int temp=n;
			int sum=0;
			while(n!=0){ //find the val of sum
				int rem=n%10;
				sum=sum+(rem*rem*rem);
				n=n/10;
			}
			if(sum==temp) Console.WriteLine(temp+" is a Armstrong number"); //check for  Armstrong
			else  Console.WriteLine(temp+" is not  a Armstrong number");
	}
}