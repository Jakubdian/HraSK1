using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Bytost
    {
        public string name;
        public int health = 100; //0 - 100
        public int intelligence = 10;
        public int mood = 50;

        virtual public void Greeting()
        {
            Console.WriteLine($"{name}: Zdravím tě...");
        }
    }
}
