using System;
class CalculatePriceAccoringToQuantityAndPrice{
	static void Main(String []args){
		Console.WriteLine("Enter the unit price ");
		double unitPrice=double.Parse(Console.ReadLine()); //input unit price
		Console.WriteLine("Enter the quantity of the item ");
		double quantity=double.Parse(Console.ReadLine()); //input quantity
		double totlePrice=unitPrice*quantity; //totle price =unitprice*quantity
		Console.WriteLine("The total purchase price is INR "+totlePrice+" if the quantity "+quantity+" and unit price is INR "+unitPrice);
		
		
		
	}
}