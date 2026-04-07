using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Mage : Bytost
    {
        public bool staff = true;
        public bool spellbook = true;
        public bool cloak = true;
        public int mana = 25;
        public int intelligence = 20;

        override public void Greeting() //Aplikace polymorfismu
        {
            Console.WriteLine("{0}: Hmmm...", name);
        }

        public Mage() //Konstruktor
        {
            defense -= 0;
            strength -= 5; //Ke zděděné hodnotě 10 přičteme 5
            dexterity -= 5;
            weapon = true;

            Prace_ze_souborem Soubor = new Prace_ze_souborem();
            Questions = Soubor.Cteni_ze_souboru("Questions_Mage.txt");
            Answers = Soubor.Cteni_ze_souboru("Answers_Mage.txt");
        }

    }
}
