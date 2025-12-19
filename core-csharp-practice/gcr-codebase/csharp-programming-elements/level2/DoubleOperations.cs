using System;
class DoubleOperations{
	static void Main(String []args){
		Console.WriteLine("Enter the value of a u can also use decimal values");
		Double a=double.Parse(Console.ReadLine());//input value of a  u can also use decimal values
		Console.WriteLine("Enter the value of b u can also use decimal values");
		double b=double.Parse(Console.ReadLine());//input value of b u can also use decimal values
		Console.WriteLine("Enter the value of c u can also use decimal values");
		double c=double.Parse(Console.ReadLine());//input value of c u can also use decimal values
		double op1=a+b*c;//Operation 1
		double op2=a*b+c;//Operation2 
		double op3=c+a/b;//Operation 3
		double op4=a%b+c;//Operation 4
		Console.WriteLine("The results of Double Operations are "+op1+" , "+op2+" , "+op3+" and "+op4);
		
	}
}