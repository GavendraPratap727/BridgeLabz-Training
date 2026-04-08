using System;
class DaysOfWeek{
		static void Main(String[]args){
			Console.WriteLine("Enter the month in number "); //enter month day and year
			int m=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the day in number ");
			int d=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the year in number ");
			int y=int.Parse(Console.ReadLine());
			
			int yy = y - (14 - m) / 12;  //find the days of week as the formula says
           int x = yy + yy / 4 - yy / 100 + yy / 400;
          int mm = m + 12 * ((14 - m) / 12) - 2;
           int dd = (d + x + (31 * mm) / 12) % 7;
		   Console.WriteLine("Days in weeks are-: "+dd);
		
			
		}
}