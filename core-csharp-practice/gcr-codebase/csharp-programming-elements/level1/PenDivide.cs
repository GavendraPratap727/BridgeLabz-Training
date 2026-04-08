using System;
class PenDivide{
	static void Main(String []args){
		int pen=14; // totle no of pens
		int student=3; //totle number of students
		int pen_per_student=pen/student; //pen distributed
		int remaining=pen%student; //remaning pens
		Console.WriteLine("The Pen Per Student is "+pen_per_student+" and the remaining pen not distributed is "+remaining);
		
	}
}