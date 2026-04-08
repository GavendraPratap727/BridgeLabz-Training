using System;

public class AreaOfCircle {
    public static void Main(String[] args) {
        Console.Write("Enter the radiuf of circle");
       
        double r=double.Parse(Console.ReadLine());
        double area=3.14*r*r;
        Console.WriteLine("Area of circle="+area);
    }
    
}
