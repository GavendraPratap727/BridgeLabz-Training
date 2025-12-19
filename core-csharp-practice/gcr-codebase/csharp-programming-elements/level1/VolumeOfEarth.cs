using System;
class VolumeOfEarth{
	static void Main(String [] args){
		double radiuskm=6378; //radius of earth in km
		double pi=3.141; //pi value
		double volInkm=(4.0/3.0)*pi*radiuskm*radiuskm*radiuskm; //vol of sphere(4/3)*pi*radius^3;
		//now 1 km =0.621371 miles
		double radiusMiles=radiuskm*0.621371; 
		double volInMiles=(4.0/3.0)*pi*radiusMiles*radiusMiles*radiusMiles; //vol of sphere(4/3)*pi*radius^3;
		Console.WriteLine("The volume of earth in cubic kilometers is "+volInkm+" and cubic miles is  "+volInMiles);
	}
}