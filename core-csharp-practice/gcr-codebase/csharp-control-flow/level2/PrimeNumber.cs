using System;
class PrimeNumber{
	static void Main(String []args){
		Console.WriteLine("Enter a number");
		int n=int.Parse(Console.ReadLine());//input a number
		bool isPrime=true;
	if(n<=0){  //check it s natural number or not
	Console.WriteLine("Enter a natural number");
	return;}
	if(n==1||n==2||n==3){
		isPrime=true;
	}
	else{
		for(int i=2;i<=n/2;i++){ //use loop from 2 to n/2 
			if(n%i==0) {
				isPrime=false;
			break;}
			
		}
	}
	Console.WriteLine("the number is prime?"+isPrime);
	
	}
}