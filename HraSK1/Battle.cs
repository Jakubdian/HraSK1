using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Battle
    {
        Minihry m = new Minihry();

        public void Souboj(Player p, Bytost nepritel)
        {
            while (p.health > 0 && nepritel.health > 0)
            {
                p.StatList();
                Console.WriteLine($"{nepritel.name} má {nepritel.health} HP.");
                Console.WriteLine("Vyber kouzlo (zadej číslo):");

                for (int i = 0; i < p.mojeKouzla.Count; i++)
                {
                    Console.WriteLine($"{i} - {p.mojeKouzla[i].nazev} (Stojí {p.mojeKouzla[i].cenamany} many)");
                }

                int volba = int.Parse(Console.ReadLine());
                Kouzlo k = p.mojeKouzla[volba];

                if (p.mana >= k.cenamany)
                {
                    int combo = 0;
                    while (p.mana >= k.cenamany)
                    {
                        int rychlost = Math.Max(10, 60 - (combo * 10));
                        if (m.TimingKulicka(rychlost) == 1)
                        {
                            combo++;
                            p.mana -= k.cenamany;
                            int poskozeni = k.sila + (combo * 2);
                            nepritel.health -= poskozeni;
                            Console.WriteLine($"\nZÁSAH! Combo {combo}x! Ubral jsi {poskozeni}.");
                            Thread.Sleep(600);
                        }
                        else { Console.WriteLine("\nVedle! Konec comba."); break; }
                    }
                }
                else { Console.WriteLine("Máš málo many!"); }

                // Útok nepřítele
                if (nepritel.health > 0)
                {
                    if (m.Uhyb()) Console.WriteLine("Uhnul jsi!");
                    else { p.health -= 20; Console.WriteLine("Dostal jsi ránu za 20 HP!"); }
                }
            }
            if (p.health > 0) Console.WriteLine("\nVYHRÁL JSI SOUBOJ!");
        }
    }
}

