using System;
class FindNumberOfRounds{
	static void Main(String[] args){
		Console.WriteLine("Enter value of  3 sides of the Park");
		double a=double.Parse(Console.ReadLine()); //input the distance of 1st side
		double b=double.Parse(Console.ReadLine()); //input the distance of 2nd side
		double c=double.Parse(Console.ReadLine());//input the distance of 3side
		double per=a+b+c;// perimeter of a triangle is the addition of all sides 
		double round=5/per;
		Console.WriteLine("The total number of rounds the athlete will run is "+round+"  to complete 5 km");
		
		
		
	}
}

