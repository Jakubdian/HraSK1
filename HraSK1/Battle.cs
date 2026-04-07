using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Battle
    {
        public void Utok(Warrior warrior1, Warrior warrior2)
        {
            if (warrior1.mood <= 5)
            {
                Console.WriteLine(warrior1.name + ": " + "začal/a útočit");
            }

            if (warrior2.mood <= 5)
            {
                Console.WriteLine(warrior2.name + ": " + "začal/a útočit");
            }

        }

        public void Utok(Mage mage1, Mage mage2)
        {
            if (mage1.mood <= 5)
            {
                Console.WriteLine(mage1.name + ": " + "začal/a útočit");
            }

            if (mage2.mood <= 5)
            {
                Console.WriteLine(mage2.name + ": " + "začal/a útočit");
            }

        }
    }
}
