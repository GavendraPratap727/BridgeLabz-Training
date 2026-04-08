using System;
class SamMarks{
	static void Main(String []args){
		int math_marks=94; // sam marks in maths
		int phy_marks=95; // sam marks in physics
		int che_marks=96; //sam marks in chemistry
		double avg_marks=(math_marks+phy_marks+che_marks)/3; //average of these marks= totle marks/no of subject
		Console.WriteLine(" Sam’s average mark in PCM is "+avg_marks.ToString("0.0"));
	}
}