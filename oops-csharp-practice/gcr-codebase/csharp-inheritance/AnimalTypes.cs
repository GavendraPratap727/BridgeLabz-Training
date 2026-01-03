using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Inheritance
{
    class Animal {
        public string name;
        public int age;
        public Animal(string name, int age) {
            this.name = name;
            this.age = age;
           
        }
        public virtual void MakeSound() {
            
            Console.WriteLine("Animal make a sound");
        }

    }
    class Dog : Animal {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound() {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Age " + age);
            Console.WriteLine("Dog barks");
        }

    }
    class Cat: Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Age " + age);
            

            Console.WriteLine("Cat meow");
        }

    }
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Age " + age);

            Console.WriteLine("Birds chrips");
        }

    }
    class AnimalTypes
    {
        
        static void Main(string[] args) {
            Animal[] an = new Animal[3];
            an[0]= new Dog("Sheru", 3);
            an[1]= new Cat("Kalu billa", 2);
            an[2]= new Bird("Chidiya", 1);
            foreach (Animal a in an) {
                a.MakeSound();
                Console.WriteLine();
            }


        }
    }
}
