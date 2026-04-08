using System;
class InputStudentFeeDiscount{
	static void Main(String []args){
		Console.WriteLine("Enter the fee of  course");
		double fee=double.Parse(Console.ReadLine()); //fee of college
		Console.WriteLine("Enter the per of discount");
		
		double discountPercent=double.Parse(Console.ReadLine()); //discount percentage
		
		double discount=(discountPercent*fee)/100; //How much discount collage give in rupee
		double final_fee=fee-discount; //final fee after discount
		Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+final_fee);
		
	}
}