using System;
class Operatorss{
 static void Main(String[]args){
  //1.Arithmetic Operators
  
  int a=1;int b=2;
  
  //Addition operator-: Adds two operands.
  
  Console.WriteLine("Addition"+(a+b)); 
  
  //Subtraction operator-: Subtracts the right operand from the left.
  
  Console.WriteLine("Subtraction"+(a-b));
  
  //Multiplication operator-:Multiplies two operands.
  
  Console.WriteLine("Multiplication"+(a*b));
  
  //Division operator-:Divides the left operand by the right.
  
  Console.WriteLine("Division"+(a/b));
  
  //Modulus operator-:Returns the remainder of the division.
  
  Console.WriteLine("Modulus"+(a%b));
  
  
  //2. Relational Operators
  
  //Equal to (==): Checks if two operands are equal.
  
  Console.WriteLine("is a ==b-: "+(a==b));
  //Not equal to (!=): Checks if two operands are not equal.
  
  Console.WriteLine("is a !=b-: "+(a!=b));
  
  //Greater than (>): Checks if the left operand is greater than the right.
  
  Console.WriteLine("is a >b-: "+(a>b));
  
  //Less than (<): Checks if the left operand is less than the right.
  
  Console.WriteLine("is a <b-: "+(a<b));
  
  //Greater than or equal to (>=): Checks if the left operand is greater than or equal to the right.
  
  Console.WriteLine("is a >=b-: "+(a>=b));
  
  //3. Logical Operators
  
  int c=1;int d=2;int e=3;
  
  //Logical AND (&&): Returns true if both operands are true.
  
  Console.WriteLine("is c <d and d>e "+(c<d && d>e));
  
  //Logical OR (||): Returns true if at least one operand is true.
  
  Console.WriteLine("is c <d or d>e "+(c<d || d>e));
  
  //Logical NOT (!): Reverses the logical state of its operand.
  
  Console.WriteLine(" not of  c <d  "+!(c<d ));
  
  //4. Assignment Operators
  
  int one =1; 
  //Assignment (=): Assigns the right operand to the left operand.
  int first=one;
  Console.WriteLine("Value of first variableby using = operator ="+first);
  
  //Addition assignment (+=): Adds the right operand to the left operand and assigns theresult to the left operand.
  first+=one;
  Console.WriteLine("new val of first by using += operator ="+first);
  
  //Subtraction assignment (-=): Subtracts the right operand from the left operand and assigns the result.
   first-=one;
  Console.WriteLine("new val of first by using -= operator ="+first);
  
  //Multiplication assignment (*=): Multiplies the right operand with the left operand and assigns the result.
   first*=one;
  Console.WriteLine("new val of first by using *= operator ="+first);
  
  //Division assignment (/=): Divides the left operand by the right operand and assigns the result.
  
   first/=one;
  Console.WriteLine("new val of first by using /= operator ="+first);
  
  //Modulus assignment (%=): Takes the modulus using two operands and assigns the result.
  
  first%=one;
  Console.WriteLine("new val of first by using %= operator ="+first);
  
  //5. Unary Operators
   
   //Unary plus (+): Indicates a positive value.
   
   Console.WriteLine("value of a :"+a);
   
   //Increment (++): Increases the value by 1.
   
   a=++a;
   Console.WriteLine("a value using preincremment="+a); // increment value by 1 before calling 
   a=a++;
   Console.WriteLine("a value using postincremment="+a); // increment value by one after  calling
   
   //Decrement (--): Decreases the value by 1.
   
   a=--a;
   Console.WriteLine("a value using preDecrement="+a); // Decrement value by 1 before calling 
   a=a--;
   Console.WriteLine("a value using postDecrement="+a); // Decrement value by one after  calling
   
   //Logical complement (!): Inverts the value of a boolean.
   
   bool ba=true;
   
   Console.WriteLine("complement of ba variable = "+!ba);
   
   //7. Ternary Operator -:It works likes if else statement but in single like 
   
   int ok=a>b?1:0;
   
   Console.WriteLine("Value of ok is"+ok); //value of ok is 0 beacause a not greater than b-
   
   //8. is Operator -:In C#, the is operator checks if an object is compatible with a specific type.
   
   Operatorss op=new Operatorss();
 
   Console.WriteLine("op is Operatorss :"+( op is Operatorss));
   Console.WriteLine("op is String :"+( op is String));
   
   
   
 }
}