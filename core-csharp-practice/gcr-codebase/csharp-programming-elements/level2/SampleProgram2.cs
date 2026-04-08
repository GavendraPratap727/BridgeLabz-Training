using System;
class SampleProgram2{
	static void Main(String[] args){
		Console.WriteLine("Enter the name,starting city name,Via city name,Tocity name,startingcity to via city distance.via city to to city distance,and both distace travel time in hrs");
		String name=Console.ReadLine(); //name of the person
		String startingCity=Console.ReadLine(); //strting city name
		String viaCity=Console.ReadLine(); //via city name
		String toCity=Console.ReadLine(); //Final city name
		double dstartcity=double.Parse(Console.ReadLine()); //start city to via city distance
		double dviacity=double.Parse(Console.ReadLine()); //via city to final city distance
		double tstartcity=double.Parse(Console.ReadLine()); //time taken to reachstart city to via city 
		double tviacity=double.Parse(Console.ReadLine()); //time taken to reach via city to final city
		double totled=dstartcity+dviacity; //add both distance to find totle distance
		double totletime=tstartcity+tviacity; //add both timetakn to find tole time taken
		Console.WriteLine(" The results of the trip are: " +name+" , "+totled+" , "+totletime);
		
	}
}