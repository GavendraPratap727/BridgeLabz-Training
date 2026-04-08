using System;
class DiscountedCollegeFee{
	static void Main(String []args){
		double fee=125000; //fee of college
		double discountPercent=10; //discount percentage
		double discount=(discountPercent*fee)/100; //How much discount collage give in rupee
		double final_fee=fee-discount; //final fee after discount
		Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+final_fee);
		
	}
}