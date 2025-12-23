using System;
class AbundantNumber{
	static void Main(String[] args){
		Console.WriteLine("Enter a number ");
		int num=int.Parse(Console.ReadLine()); //input a number 
		int sum=0;
		for(int i=1;i<=num/2;i++){ //find the factors and sum them
			if(num%i==0)  sum+=i;
		}
		if(sum>num)Console.WriteLine("yes it is Abundant Number" );
		else Console.WriteLine("NO it is not Abundant Number" );
	}
}