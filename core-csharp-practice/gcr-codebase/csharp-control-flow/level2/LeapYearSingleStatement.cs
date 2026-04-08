using System;
class LeapYearSingleStatement{
	static void Main(String []args){
		Console.WriteLine("Enter the year to check wether it is leap year or not(year must>1581)");
		int year=int.Parse(Console.ReadLine()); //input a year
		if(year>=1582&&(year%400==0||(year%4==0&&year%100!=0))) Console.WriteLine("Leap year"); //this method only works year above that 1581 so we check it is above  1581 or not and other conditions
		
		else Console.WriteLine("Not leap year");
		
	}
}