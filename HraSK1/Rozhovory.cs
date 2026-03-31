using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Rozhovory
    {
        public void Dialog(Warrior warrior1, Warrior warrior2)
        {
            warrior1.Greeting();
            warrior2.Greeting();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(warrior1.name + ": " + warrior1.Questions[i]);
                Console.WriteLine(warrior2.name + ": " + warrior2.Answers[i] + "\n");
            }
        }
        public void Dialog(Bytost bytost1, Bytost bytost2)
        {
            bytost1.Greeting();
            bytost2.Greeting();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bytost1.name + ": " + bytost1.Questions[i]);
                Console.WriteLine(bytost2.name + ": " + bytost2.Answers[i] + "\n");
            }
        }
        public void Dialog(Mage mage1, Mage mage2)
        {
            mage1.Greeting();
            mage2.Greeting();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(mage1.name + ": " + mage1.Questions[i]);
                Console.WriteLine(mage2.name + ": " + mage2.Answers[i] + "\n");
            }
        }
    }
}
