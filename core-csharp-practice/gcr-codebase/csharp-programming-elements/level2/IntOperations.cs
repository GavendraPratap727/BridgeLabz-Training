using System;
class IntOperations{
	static void Main(String []args){
		Console.WriteLine("Enter the value of a");
		int a=int.Parse(Console.ReadLine()); //input value of a
		Console.WriteLine("Enter the value of b");
		int b=int.Parse(Console.ReadLine()); //input value of b
		Console.WriteLine("Enter the value of c");
		int c=int.Parse(Console.ReadLine()); //input value of c
		int op1=a+b*c; //operation1
		int op2=a*b+c; //operation 2
		int op3=c+a/b;//operation3
		int op4=a%b+c;//operation  4
		Console.WriteLine("The results of Int Operations are "+op1+" , "+op2+" , "+op3+" and "+op4);
		
	}
}