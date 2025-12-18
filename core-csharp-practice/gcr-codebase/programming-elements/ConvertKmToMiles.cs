using System;
public class ConvertKmToMiles{
public static void Main(String []args){
Console.WriteLine("Enter the Km to change into Miles");
double km=double.Parse(Console.ReadLine());
Console.Write(km+"Kilometer ="+(km+0.621371));

}
}