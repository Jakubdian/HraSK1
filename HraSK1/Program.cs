using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytváření objektů
            Bytost tree = new Bytost();
            Bytost Groot = new Bytost();
            Bytost dog = new Bytost();

            Warrior Patricia = new Warrior();

            //Přiřazování vlastvností objektům
            tree.vigor = 80;
            Groot.age = 180;
            Groot.name = "Groot";
            Patricia.name = "Patrícia";

            dog.ZapisSound("Bark");

            tree.Greeting();
            Groot.Greeting(true);
            dog.Greeting(true);
            Patricia.Greeting();

            Console.ReadKey();
        }
    }
}
