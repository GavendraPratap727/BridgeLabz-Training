using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BirdSanctuary
{
    public class Sparrow : Bird, IFlyable
    {
        public Sparrow(string NameOfBird) : base(NameOfBird, "Species") { }
        public void Fly()
        {
            Console.WriteLine("Sparrow flies low to the ground");

        }
    }
}
