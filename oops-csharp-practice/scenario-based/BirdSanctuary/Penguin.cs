using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BirdSanctuary
{
    public class Penguin : Bird, ISwimmable
    {
        public Penguin(string NameOfBird) : base(NameOfBird, "Penguin") { }
        public void Swim()
        {
            Console.WriteLine("Penguin swim swiftly on water");
        }

    }
}
