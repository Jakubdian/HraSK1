using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Player : Bytost
    {
        public string playerClass = "Mage";
        public int mana = 25;
        public int intelligence = 20;

        public Player(string chosenname)
        {
            name = chosenname;
        }

        public Home(string chosenhome)
        {
            home = chosenhome
        }

        public void ShowStats()
        {
            Console.WriteLine("=== YOUR STATS ===");
            Console.WriteLine("Name:         " + name);
            Console.WriteLine("Class:        " + playerClass);
            Console.WriteLine("Vigor:        " + health);
            Console.WriteLine("Strength:     " + strength);
            Console.WriteLine("Intelligence: " + intelligence);
            Console.WriteLine("Mana:         " + mana);
            Console.WriteLine("Defense:      " + defense);
            Console.WriteLine("==================");
        }
    }
}
