using System;
class ConvertFeetIntoMilesAndYard{
	static void Main(String []args){
		Console.WriteLine("Enter ditance in feets");
		double feet=double.Parse(Console.ReadLine()); //input the distance feet
		double yard=feet/3; //3feet=1yards
		double miles=yard/1760; //1mile=1760 yard
		Console.WriteLine("Distance in feet is "+feet+" Distane in yards "+yard+" Distance in miles "+miles);
	    
	}
}
