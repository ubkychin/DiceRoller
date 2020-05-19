using System;
using System.Collections.Generic;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game("John", "Jane");
            g.Start();
        }
    }


}
