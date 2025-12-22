using System;
class EvenOdd{
	static void Main(String[]args){
		Console.WriteLine("Enter a number");
		int n=int.Parse(Console.ReadLine()); //Input a number
		if(n<=0) { //check wheather it is natural ot not
			Console.WriteLine("Enter a natural number");
			return;
		}
		for(int i=1;i<=n;i++){ //for loop ittirate from 1 to n
			if(i%2==0){ //check it is even or not
				Console.WriteLine(i+" Is Even");
			}
			else	Console.WriteLine(i+" Is Odd"); //if number is odd
			
		}
		
	}
}