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
            Warrior Chuchy = new Warrior();

            Mage Gandalf = new Mage();
            Mage Brumbal = new Mage();

            Rozhovory rozhovor = new Rozhovory();

            Battle battle = new Battle();

            //Přiřazování vlastvností objektům
            tree.health = 80;
            Groot.age = 180;
            Groot.name = "Groot";
            Patricia.name = "Patrícia";
            Chuchy.name = "Chuchy";
            Gandalf.name = "Gandalf";
            Brumbal.name = "Brumbal"; 

            //dog.ZapisSound("Bark");

            //tree.Greeting();
            //Groot.Greeting(true);
            //dog.Greeting(true);
            //Patricia.Greeting();

            //rozhovor.Dialog(Chuchy, Patricia);
            //battle.Utok(Chuchy, Patricia);
            //Console.WriteLine("\n");

            //rozhovor.Dialog(Groot, tree);

            //Console.WriteLine("\n");

            //rozhovor.Dialog(Gandalf, Brumbal);
            //battle.Utok(Brumbal, Gandalf);

            Console.WriteLine("=== WELCOME TO HOGWARTS ===");
            Console.WriteLine("Enter your name: ");
            string playername = Console.ReadLine();

            Player player = new Player(playername);
            Console.WriteLine("\nWelcome, " + playername + "!");
            player.ShowStats();

            Console.WriteLine("Welcome students we are really happy to have you here!");
            Console.WriteLine("Today it's big day for all of you, you are gonna be sorted to your new homes.");

            string home = Console.ReadLine();
            Home home = new Home(playerhome);
            Console.WriteLine("Choose your home: ");
            Console.WriteLine("1 - Ravenpuff");
            Console.WriteLine("2 - Slytherin");
            Console.WriteLine("3 - Hufflepuff");
            Console.WriteLine("4 - Gryffindor");
            Console.ReadKey();
        }
    }
}
