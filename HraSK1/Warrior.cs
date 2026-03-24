using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Warrior:Bytost
    {
        public bool shield = true;
        public bool dagger = true;
        public int speed = 50; //0 - 100

        override public void Greeting() //Aplikace polymorfismu
        {
            Console.WriteLine("{0}: Oh, hi dih...", name);
        }

        public Warrior() //Konstruktor
        {
            strength += 20; //Ke zděděné hodnotě 10 přičteme 20
            dexterity += 20;
            weapon = true;
        }
    }
}
