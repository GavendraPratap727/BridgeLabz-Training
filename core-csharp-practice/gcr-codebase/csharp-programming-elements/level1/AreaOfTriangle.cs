using System;
class AreaOfTriangle{
	static void Main(String []args){
		Console.WriteLine("Enter the value of base of triangle"); 
		double baseOf=double.Parse(Console.ReadLine()); //input the base of trangle
		Console.WriteLine("Enter the value of height of triangle");
		double hei=double.Parse(Console.ReadLine()); //input the height of triangle
		double sqInch= 0.5*baseOf*hei; //area of trangle id 1/2*base *height 
		double sqcenti=sqInch*6.4516; //1 inch=6.4516
		Console.WriteLine("Area of triangle in square inches is "+sqInch+" and in square centimeters is "+sqcenti);
		
		
	}
}