using System;


public class SimpleIntrest {
    public static void Main(String[] args) {
       
        double prin=20000; //Input principal
        double rate=5; //Input rate
        double time=2; //Input time in years
        double si=(prin*rate*time)/100;
        Console.WriteLine("Simple Intrest="+si);
    }
    
}
