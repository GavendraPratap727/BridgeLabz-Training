 using System;
class DataTypes{
 static void Main(String []args){
 
 //Boolean -:in these variable contains only 1 value either true or false its size is 1 byte
 
  bool f=true;
  Console.WriteLine("f is boolean variable and its value is -:"+f);
  
  // byte it store integer value its size is 1 Byte
  byte a= 2;
  Console.WriteLine("a is byte variable and its value is -:"+a);
  
  //short it also stores integer value and its size is 2 Bytes
  
  short b=22;
  Console.WriteLine("b is short variable and its value is -:"+b);
  
  //int it also stores integer value and its size is 4 Bytes
  
  int c= 2222;
  Console.WriteLine("c is int variable and its value is -:"+c);
  
  //long it also stores integer value and its size is 8 Bytes
  
  long d=98745;
  Console.WriteLine("d is long variable and its value is -:"+d);
  
  //float it store decimal value and its size is 4 byte
  
  float e=10.5f;
  Console.WriteLine("e is float variable and its value is -:"+e);
  
  //Double it store decimal value and its size is 8 byte
  
  double g=99.6545;
  Console.WriteLine("g is double variable and its value is -:"+g);
  
  //char it store character and its size is 2 byte
  
  char h='A';
  Console.WriteLine("h is char variable and its value is -:"+h);
  
  
  
  
  
  
  //Type Conversion two types of conversion implicit and explicit
  
  
  
  //char to int  it is Implicit coneversion
  
  char ch='A';
  int chi=ch;
  Console.WriteLine("value of chi-:"+chi);
  
  
  //int to float it is Implicit coneversion
  
  int aa=2;
  float aaa=aa;
  Console.WriteLine("value of aaa-:"+aaa.ToString("0.0"));
  
  //int to double it is Implicit coneversion
  int bb=22;
  double bbb=bb;
  Console.WriteLine("value of bbb-:"+bbb.ToString("0.0"));
  
  //short to int it is Implicit coneversion
  
  short s=2;
  int i=s;
  Console.WriteLine("value of i="+i);
  
  //double to int it is explicit coneversion
  
  double x=1.99;
  int y=(int)x;
  Console.WriteLine("value of y =" +y);
  
  
  //int to short it is explicit coneversion
  int t=33;
  short u=(short)t;
  Console.WriteLine("value of u is = "+u);
  
 }
}