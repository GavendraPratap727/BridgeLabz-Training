using System;
class Parent{
	//public access modifier-:can access anywhere
	//private access modifier -:members can only access with in a same class
	//protected access modifier-:member can only access with ina smae or ina drived class
	//internal access modifier-:member can only be acces only ina same project but no outside of the project
	//protected internal access modifier-: memebrs can be access either ina same project or in a drived class if allow the drived class which is in driffrent project
	//member s can be only acces with in  a same project and only by the drived class
	
	public int publica=1;
	private int privatea=2;
	protected int procteda=3;
	internal int internala=4;
	protected internal int  prointernala=50;
	//private protected int priprotecteda=60;
	public void Showp(){
		Console.WriteLine("Inside parent class");
		Console.WriteLine(publica);
		Console.WriteLine(privatea);
		Console.WriteLine(procteda);
		Console.WriteLine(internala);
		 Console.WriteLine(prointernala);
		//Console.WriteLine(priprotecteda);
	}
}
class Child:Parent{
	public void Showc(){
		Console.WriteLine("Inside child class");
		Console.WriteLine(publica);
		//Console.WriteLine(privatea); //not allow
		Console.WriteLine(procteda);
		Console.WriteLine(internala);
		Console.WriteLine(prointernala);
		//Console.WriteLine(priprotecteda);
		
	}
}
class Other{
	public void Showo(){
		Parent p=new Parent();
		Console.WriteLine("Inside other class");
		Console.WriteLine(p.publica);
		//Console.WriteLine(privatea); //not allow
		//Console.WriteLine(procteda); //not allow
		Console.WriteLine(p.internala);
		Console.WriteLine(p.prointernala);
		// Console.WriteLine(priprotecteda); //not allow
		
	}
}
class AccessModifiers{
static void Main(string []args){
Parent p=new Parent();
p.Showp();
Child c=new Child();
c.Showc();
Other o=new Other();
o.Showo();

}
}