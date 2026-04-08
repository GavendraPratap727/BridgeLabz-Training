using System;
class DivideChocolates{
	static void Main(String []args){
		Console.WriteLine("Enter totle number of Chocolates");
	    int Chocolates =int.Parse(Console.ReadLine());; // totle no of Chocolates
		Console.WriteLine("Enter totle number of Childern");
		int child=int.Parse(Console.ReadLine()); 	; //totle number of child
		int Chocolates_per_child=Chocolates/child; //Chocolates distributed
		int remaiing=Chocolates%child; //remaning Chocolates
		Console.WriteLine("The number of chocolates each child gets is "+Chocolates_per_child+" and the number of remaining chocolates is  "+remaiing);
		
	}
}