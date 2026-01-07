using System;
using System.Collections.Generic;
using System.Text;

namespace bridge
    .Opps_senario.BirdSanctuary;

public class BirdSanctuarySystem
{
    static void Main(string[] args)
    {
        Bird[] birds =
        {
            new Eagle("Alpha"),
            new Sparrow("Beta"),
            new Duck("Delta"),
            new Penguin("Fluff"),
            new Seagull("Booa")
        };
        SanctuaryMenu menu = new SanctuaryMenu(birds);
        menu.ShowMenu();
    }
}
