using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Constructor
{
    using System;

    class Person
    {
        string name;
        int age;
        string country;

        Person() : this("Default Human", 0, "No Nationality")
        {
            Console.WriteLine("\nDefault Constructor called");
        }

        Person(string name, int age, string country)
        {
            Console.WriteLine("\nParameterized Constructor Called");
            this.name = name;
            this.age = age;
            this.country = country;
        }

        Person(Person h)
        {
            Console.WriteLine("\nCopy Constructor Called");
            name = h.name;
            age = h.age;
            country = h.country;
        }

        void show()
        {
            Console.WriteLine("Person Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Nationality: " + country);
        }

        void setName(string name)
        {
            this.name = name;
        }

        static void Main()
        {
            Person h1 = new Person("Gavendra", 22, "Indian");
            Person h2 = new Person(h1);
            h1.show();
            h2.show();
            h2.setName("Love");
            h1.show();
            h2.show();
        }
    }

}
