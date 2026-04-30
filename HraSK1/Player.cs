using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Player : Bytost
    {
        public string kolej;
        public int mana = 50;
        public int maxmana = 50;
        public List<Kouzlo> mojeKouzla = new List<Kouzlo>();

        public Player(string jmeno)
        {
            name = jmeno;
            // Základní kouzlo do začátku
            mojeKouzla.Add(new Kouzlo("Mdloby na tebe", 10, 5));
        }

        public void StatList()
        {
            Console.WriteLine($"\n[ {name} | Kolej: {kolej} | HP: {health} | Mana: {mana} ]");
        }
    }
}
