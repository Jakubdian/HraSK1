using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Bytost
    {
        public string name = "bytost";
        public int age;

        public int vigor = 100; //0 - 100
        public int strength; //0 - 100
        public int dexterity = 10; //0 - 100
        public int defense = 10; //0 - 100

        public bool weapon = false;

        public Inventory[] weapons = new Inventory[3];

        private string sound = "groot";

        virtual public void Greeting()
        {
            Console.WriteLine("{0}: ...", name);
        }

        public void Greeting(bool sound)
        {
            Console.WriteLine("{0}: {1}", name, this.sound);
        }

        public void ZapisSound(string sound)
        {
            this.sound = sound;
        }
    }
}
