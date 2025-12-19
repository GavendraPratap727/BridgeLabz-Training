using System;
class TotleIncome{
	static void Main(String [] args){
		Console.WriteLine("Enter the salary of the person");
		double salary=double.Parse(Console.ReadLine()); //Input the slaary of the person 
		Console.WriteLine("Enter the bonus of the person");
		double bonus=double.Parse(Console.ReadLine()); //input the bonus of that person
		double totlein=salary+bonus; //add both salary and bonus to find totle income
		Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+" Hence Total Income is INR "+totlein);
		
		
		
	}
}