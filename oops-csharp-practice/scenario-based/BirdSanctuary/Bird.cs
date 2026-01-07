using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BirdSanctuary
{
    
        public class Bird
        {
            public string NameOfBird { get; set; }
            public string Species { get; set; }
            public Bird(string NameOfBird, string Species)
            {
                this.NameOfBird = NameOfBird;
                this.Species = Species;
            }
            public void DisplayInfo()
            {
                Console.WriteLine("Name of the bird : " + NameOfBird + ", species : " + Species);
            }
        }
    }

