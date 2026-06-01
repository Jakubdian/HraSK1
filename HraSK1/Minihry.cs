using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace HraSK1
{
    internal class Minihry
    {
        public int TimingKulicka(int rychlost)
        {
            while (Console.KeyAvailable) { Console.ReadKey(true); }

            // Použijeme raději lokální souřadnici od 0 pro absolutní jistotu
            int pozice = 0;
            bool vpravo = true;

            // Před minihrou odskočíme na čisté místo nebo vymažeme předchozí řádek
            Console.WriteLine("\nTref se doprostřed [  X  ] mezerníkem!");

            // Zjistíme si aktuální řádek po vypsání hlášky
            int startovniRadek = Console.CursorTop;

            // Pojistka: Pokud jsme na úplném dně konzole, raději vyčistíme obrazovku, 
            // aby se nám nezhroutily souřadnice bufferu
            if (startovniRadek >= Console.BufferHeight - 2)
            {
                Console.Clear();
                Console.WriteLine("Tref se doprostřed [  X  ] mezerníkem!");
                startovniRadek = Console.CursorTop;
            }

            while (!Console.KeyAvailable)
            {
                // Vracíme se na bezpečně ověřený řádek
                Console.SetCursorPosition(0, startovniRadek);
                char[] radek = "----------[  X  ]----------".ToCharArray();
                if (pozice < radek.Length) radek[pozice] = 'O';

                Console.Write(new string(radek));
                if (vpravo) pozice++; else pozice--;
                if (pozice >= 26 || pozice <= 0) vpravo = !vpravo;
                Thread.Sleep(rychlost);
            }
            Console.ReadKey(true); // Sebere stisknutou klávesu

            if (pozice >= 11 && pozice <= 15) return 1; // Zásah!
            return 0; // Vedle
        }

        public bool Uhyb()
        {
            Console.WriteLine("\nRYCHLE! Stiskni 'A' pro úhyb!");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < 1200) // Máš 1.2 sekundy
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.A) return true;
                }
            }
            return false;
        }
    }
}
