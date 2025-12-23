using System;
class AvgAndGrade{
	static void Main(String [] args){
		Console.WriteLine("Enter marks of Physics Chemistry and math");
		double phy=double.Parse(Console.ReadLine()); //input all 3 subject marks
		double che=double.Parse(Console.ReadLine());
		
		double math=double.Parse(Console.ReadLine());
		double avg =(phy+che+math)/3; //find avg
		if(avg>=80) Console.WriteLine("the average marks is "+avg+" Grade A Remark Level 4,above agency-normalized standards");
		else if(avg>=70 &&avg <80) Console.WriteLine("the average marks is "+avg+" Grade B Remark Level 3,at agency-normalized standards");
		else if(avg>=60 &&avg <70) Console.WriteLine("the average marks is "+avg+" Grade C Remark Level 2,Below , but approaching agency-normalized standards");
		else if(avg>=50 &&avg <60) Console.WriteLine("the average marks is "+avg+" Grade D Remark Level 1,Well below agency-normalized standards");
		else if(avg>=40 &&avg <50) Console.WriteLine("the average marks is "+avg+" Grade E Remark Level 1,Too below agency-normalized standards");
		else Console.WriteLine("Remedial standards");
		
		
		
		
		
		
		
	}
}