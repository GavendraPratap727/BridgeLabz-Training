using System;
class PerimeterOfSquare{
	static void Main(String []args){
		Console.WriteLine("Enter the peremeter of square");
		double peri=double.Parse(Console.ReadLine()); //input the perimeter of the square
		double side=peri/4; // formula to find length of 1 side of square perimeter/4
		Console.WriteLine("The length of the side is "+side+" whose perimeter is -:" +peri);
		
	}
	
}