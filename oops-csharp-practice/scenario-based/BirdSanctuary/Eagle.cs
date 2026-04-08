using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BirdSanctuary
{
    public class Eagle : Bird, IFlyable
    {
        public Eagle(string NameOfBird) : base(NameOfBird, "Eagle") { }
        public void Fly()
        {
            Console.WriteLine("Eagle fly highest in the sky");
        }
    }
}
