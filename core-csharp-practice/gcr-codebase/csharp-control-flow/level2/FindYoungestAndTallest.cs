using System;
class FindYoungestAndTallest{
	static void Main(String[]args){
		Console.WriteLine("Enter the age of all three friends");
		Console.WriteLine("Enter age of Amar");
		int amara=int.Parse(Console.ReadLine()); //input amar age
		Console.WriteLine("Enter age of Akbar");
		int akbara=int.Parse(Console.ReadLine());//input akbar age
		Console.WriteLine("Enter age of Anthony");
		int anthonya=int.Parse(Console.ReadLine());//input anthony age
		Console.WriteLine("Enter the height(cm) of all three friends");
		Console.WriteLine("Enter height of Amar");
		double amarh=double.Parse(Console.ReadLine());//input amar height
		Console.WriteLine("Enter height of Akbar");
		
		double akbarh=double.Parse(Console.ReadLine());//input akbar height
		Console.WriteLine("Enter height of Anthony");
		
		double anthonyh=double.Parse(Console.ReadLine());//input anthony height
		 if(amara<anthonya&&amara<akbara)Console.WriteLine("Yougest is amar");    //check who is youngest
		 else if(akbara<anthonya&&amara>akbara)Console.WriteLine("Yougest is akbara");
		 else Console.WriteLine("Yougest is anthony");
		 
		 if(amarh>anthonyh&&amarh>akbarh)Console.WriteLine("Tallese is amar");   ////check who is Tallest
		 if(akbara>anthonyh&&amarh<akbarh)Console.WriteLine("Tallese is akbar");
		 else Console.WriteLine("Tallest is anthony");
		 
		 
		 
		 
	}
}