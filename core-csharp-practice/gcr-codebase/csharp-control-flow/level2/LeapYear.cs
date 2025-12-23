using System;
class LeapYear{
	static void Main(String []args){
		Console.WriteLine("Enter the year to check wether it is leap year or not");
		int year=int.Parse(Console.ReadLine()); //input a year
		if(year<1582) Console.WriteLine("Enter year 1582 or above"); //this method only works year above that 1581 so we check it is above  1581 or not
		else if(year%400==0)Console.WriteLine("Leap year");
		else if(year%4==0 && ( year%100)!=0)Console.WriteLine("Leap year");
		else Console.WriteLine("Not leap year");
		
	}
}