using System;
class IsSpringSeason{
	static void Main(String[] args){
		Console.WriteLine("Enter the month in integer value");
		int mon=int.Parse(Console.ReadLine()); //enter the month as input
		Console.WriteLine("Enter the date");
		int date=int.Parse(Console.ReadLine()); //enter the date as input
		if(mon==3&&date>=20 ||mon==4||mon==5||mon==6&&date<=20){//check weather the date and come come between 20march to 20june
			Console.WriteLine("“Its a Spring Season");
		}
		else{
			Console.WriteLine("“Not a Spring Season");
			
		}
	}
}