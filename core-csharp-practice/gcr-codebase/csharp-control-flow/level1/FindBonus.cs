using System;
class FindBonus{
	static void Main(String []args){
		Console.WriteLine("Enter your salary");
		double sal=double.Parse(Console.ReadLine()); //input salary
		Console.WriteLine("Enter your years of service");
		double year=double.Parse(Console.ReadLine());  //input Salary
		if(year<=5) Console.WriteLine("You got zero bonus because u dont work more than 5 years"); //check weather the year of exp is more than 5 or not
		else{
			double bonus=(sal*5)/100; //finding 5 per bonuns
		Console.WriteLine("Your bonus amoubt is "+bonus);
			
		}
		
		
		
		
	}
}