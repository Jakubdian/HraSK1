using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Hra:Program
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("=== VÍTEJ V BRADAVICÍCH ===");
            Console.Write("Zadej své jméno: ");
            Player p = new Player(Console.ReadLine());

            Console.WriteLine("Profesorka McGonnagalová: Vítejte budoucí studenti bradavic, já jsem ředitelka Nebelvírské koleje profesorka McGonnagalová.");
            Thread.Sleep(1000);
            Console.WriteLine("\nProfesorka McGonnagalová: Přesuneme do hlavní síně kde se rozdělíte do kolejí ve kterých budete následujících 7 let bydlet.");
            Console.WriteLine("\nZmáčkni klávesu pro pokračování");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Profesorka McGonnagalová: Další nařadě je {p.name}");
            Thread.Sleep(1000);
            Console.WriteLine("\nProfesorka ti nasadí na Hlavu moudrý klobouk.");
            Thread.Sleep(1000);
            Console.WriteLine("\nMoudrý klobouk přemýšlí...");
            Thread.Sleep(1000);
            Console.WriteLine("\nVyber si: 1 - Nebelvír, 2 - Zmijozel, 3 - Mrzimor, 4 - Havraspár");

            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    p.kolej = "Nebelvír";
                    break;
                case "2":
                    p.kolej = "Zmijozel";
                    break;
                case "3":
                    p.kolej = "Mrzimor";
                    break;
                case "4":
                    p.kolej = "Havraspár";
                    break;
                default:
                    p.kolej = "Moták";
                    break;
            }

            Console.WriteLine($"\nKLOBOUK: 'Patříš do koleje {p.kolej}!'");
            Console.WriteLine($"\nCelý stůl {p.kolej}u se postaví a začne radostně tleskat!");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("--- DRUHÝ DEN - Hodina Kouzelných formulí ---");
            Console.WriteLine("Profesor Kratiknot: 'Dnes se naučíme Expelliarmus!'");
            Minihry m = new Minihry();
            if (m.TimingKulicka(60) == 1)
            {
                Console.WriteLine("\nSkvěle! Naučil ses Expelliarmus.");
                p.mojeKouzla.Add(new Kouzlo("Expelliarmus", 15, 7));
            }

            Console.WriteLine("\nNáhle vtrhl do síně lord Voldemort!");
            Bytost boss = new Bytost();
            boss.name = "Voldemort";
            boss.health = 200;

            Battle b = new Battle();
            b.Souboj(p, boss);

            Console.WriteLine("\nKONEC HRY. Děkujeme za hraní!");
            Console.ReadKey();
        }
    }
}
