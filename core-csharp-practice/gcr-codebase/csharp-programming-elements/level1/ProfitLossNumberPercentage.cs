using System;
class ProfitLossNumberPercentage{
	static void Main(String []args){
		double cp=129; //cost price
		double sp=191;//selling price
		double profit=sp-cp; //Formula to find profit from selleing price(sp) and cost price(cp)=sp-cp
		double profit_per=(profit/cp)*100; //for mula to find profit percentage (profit/costprice)*100
		Console.WriteLine("The Cost Price is INR "+cp+" and Selling Price is INR "+sp);
		Console.WriteLine("The Profit is INR "+profit+" and the Profit Percentage is "+profit_per);
		
		
	}
}