using System;
class MaximumNumberOfHandshakes{
	static void Main(String [] args){
		Console.WriteLine("Enter the number of students");
		int n=int.Parse(Console.ReadLine()); //Input number of students
		int handshakes=(n*(n-1))/2; //Formula given to find max number of handshakes can be possible 
		Console.WriteLine("max number of handshakes are = "+handshakes);
	}
}