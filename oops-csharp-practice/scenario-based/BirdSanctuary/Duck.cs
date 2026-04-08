using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BirdSanctuary
{
    public class Duck : Bird, ISwimmable
    {
        public Duck(string NameOfBird) : base(NameOfBird, "Duck") { }
        public void Swim()
        {
            Console.WriteLine("Duck swim slowly on water");
        }
    }
}
