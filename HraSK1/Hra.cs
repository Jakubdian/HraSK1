using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Hra
    {
        public void Start()
        {
            Console.Clear();
            Psani pismo = new Psani();
            Minihry m = new Minihry();
            Battle b = new Battle();

            pismo.psani("Připrav se na dobrodružství v Bradavicích!", 50, ConsoleColor.White); Console.WriteLine();

            pismo.psani("\nNež se vydáš na cestu, zadej své jméno:", 50, ConsoleColor.White); Console.WriteLine();
            string jmeno = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(jmeno))
            {
                pismo.psani("Jméno nesmí být prázdné. Zadej ho znovu:", 50, ConsoleColor.White); Console.WriteLine();
                jmeno = Console.ReadLine();
            }
            Player p = new Player(jmeno);

            Console.Clear();

            pismo.psani("Do místnosti přijde vysoká starší žena s brýlemi a v dlouhém zeleném plášti.", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nDobrý večer, budoucí studenti bradavické školy čar a kouzel! Mé jméno je profesorka McGonnagalová a budu vás provázet vaším prvním dnem v Bradavicích.", 50, ConsoleColor.White); Console.WriteLine();
            pismo.psani("\nProfesorka McGonnagalová: Přesuneme se do hlavní síně kde už všichni čekají...", 50, ConsoleColor.White); Console.WriteLine();
            pismo.psani("\nZmáčkni klávesu pro pokračování", 50, ConsoleColor.Gray); Console.ReadKey();

            Console.Clear();

            pismo.psani("Profesorka McGonnagalová: Rozřazování do kolejí bude probíhat následujícím způsobem. Zavolám vás postupně k sobě, nasadím vám na hlavu moudrý klobouk a ten rozhodne, do které koleje patříte.", 50, ConsoleColor.White); Console.WriteLine();
            pismo.psani($"\nProfesorka McGonnagalová: Další na řadě je {p.name}", 50, ConsoleColor.White); Console.WriteLine();
            pismo.psani("\nPřijdeš k profesorce, ona ti nasadí na hlavu moudrý klobouk a ten začne přemýšlet...", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nMoudrý Klobouk: Hmmm... Zajímavé, vidím vysoký potenciál...", 50, ConsoleColor.Gray); Console.WriteLine();

            string volba = "";
            while (volba != "1" && volba != "2" && volba != "3" && volba != "4")
            {
                pismo.psani("\nVyber si: 1 - Nebelvír, 2 - Zmijozel, 3 - Mrzimor, 4 - Havraspár", 50, ConsoleColor.White); Console.WriteLine();
                volba = Console.ReadLine();
                if (volba != "1" && volba != "2" && volba != "3" && volba != "4")
                {
                    pismo.psani("\nNeplatná volba! Zadej číslo od 1 do 4.", 50, ConsoleColor.White); Console.WriteLine();
                }
            }

            switch (volba)
            {
                case "1": p.kolej = "Nebelvír"; break;
                case "2": p.kolej = "Zmijozel"; break;
                case "3": p.kolej = "Mrzimor"; break;
                case "4": p.kolej = "Havraspár"; break;
            }

            pismo.psani($"\nMoudrý Klobouk: '{p.name} patří do koleje {p.kolej}!'", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani($"\nCelý stůl {p.kolej}u se postaví a začne radostně tleskat!", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nZmáčkni klávesu pro pokračování", 50, ConsoleColor.Gray); Console.ReadKey();

            Console.Clear();

            pismo.psani("Po rozřazení se všichni studenti usadí ke svým stolům a ke katedře přijde vysoký muž s brýlemi a vousy až po zem.", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nVítám vás, noví studenti. Mé jméno je Albus Brumbál a jsem ředitel této školy. Jsem rád, že vás tu mohu přivítat, a těším se na náš společný rok v Bradavicích.", 50, ConsoleColor.White); Console.WriteLine();
            pismo.psani("\nAlbus Brumbál: Nezbývá mi už říct nic jiného než – pusťte se do hostiny a zítra se uvidíme na první hodině!", 50, ConsoleColor.White); Console.WriteLine();
            pismo.psani("\nZmáčkni klávesu pro pokračování", 50, ConsoleColor.Gray); Console.ReadKey();

            Console.Clear();

            pismo.psani("Ráno se probudíš a spěcháš na svou první vyučovací hodinu.", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\n--- HODINA KOUZELNÝCH FORMULÍ ---", 50, ConsoleColor.Cyan); Console.WriteLine();
            pismo.psani("\nProfesor Kratiknot: Dobrý den, studenti. Dnes se naučíme základní, ale nesmírně užitečné kouzlo - Wingardium Leviosa! Sledujte pohyb mé hůlky: Švihnout a mávnout!", 50, ConsoleColor.White); Console.WriteLine();

            pismo.psani("\nPokus se správně provést kouzlo...", 50, ConsoleColor.Gray); Console.WriteLine();
            if (m.TimingKulicka(60) == 1)
            {
                pismo.psani("\nSkvěle! Pírko před tebou se vzneslo do vzduchu. Naučil ses Wingardium Leviosa.", 50, ConsoleColor.Green); Console.WriteLine();
                p.mojeKouzla.Add(new Kouzlo("Wingardium Leviosa", 12, 6));
            }
            else
            {
                pismo.psani("\nKouzlo se ti úplně nepovedlo, pírko jen trochu zčernalo. Ale základy už znáš.", 50, ConsoleColor.Red); Console.WriteLine();
                p.mojeKouzla.Add(new Kouzlo("Wingardium Leviosa", 8, 6));
            }
            pismo.psani("\nZmáčkni klávesu pro pokračování do dalšího dne", 50, ConsoleColor.Gray); Console.ReadKey();

            Console.Clear();

            pismo.psani("Další den tě čeká obávaný sestup do sklepení na hodinu lektvarů.", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\n--- HODINA LEKTVARŮ ---", 50, ConsoleColor.Cyan); Console.WriteLine();
            pismo.psani("\nProfesor Snape: Hlavní ingrediencí pro přípravu Lektvaru Many je správné načasování. Pokud přidáte drcené dravčí zuby příliš brzy, kotlík vám vybuchne do obličeje.", 50, ConsoleColor.White); Console.WriteLine();

            pismo.psani("\nTref správný moment pro vhození přísad...", 50, ConsoleColor.Gray); Console.WriteLine();
            if (m.TimingKulicka(50) == 1)
            {
                pismo.psani("\nUvařil jsi dokonalý lektvar! Profesor Snape tě sice nepochválil, ale aspoň si můžeš nechat 2 Mana Potiony.", 50, ConsoleColor.Green); Console.WriteLine();
                p.manaPotions += 2;
            }
            else
            {
                pismo.psani("\nZ kotlíku se vyvalil fialový kouř. Snape ti strhává body pro tvou kolej, ale aspoň jsi přežil.", 50, ConsoleColor.Red); Console.WriteLine();
            }
            pismo.psani("\nZmáčkni klávesu pro pokračování", 50, ConsoleColor.Gray); Console.ReadKey();

            Console.Clear();

            pismo.psani("Nadešel večer na Halloween. Školou otřese strašlivá zpráva.", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nProfesor Quirrell: Vběhne udýchaný do síně: 'Troll! Ve sklepení! Myslel jsem... že byste to měli vědět...'", 50, ConsoleColor.White); Console.WriteLine();
            pismo.psani("\nVypukne panika. Ty si ale uvědomíš, že na dívčích záchodcích zůstala schovaná tvá kamarádka. Běžíš jí na pomoc!", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nRozkopneš dveře záchodků a uvidíš obrovského, smrdutého Horského Trolla s masivním kyjem!", 50, ConsoleColor.DarkRed); Console.WriteLine();
            pismo.psani("\nZmáčkni klávesu pro zahájení boje s Trollem!", 50, ConsoleColor.Gray); Console.ReadKey();

            Bytost troll = new Bytost();
            troll.name = "Horský Troll";
            troll.health = 90;
            b.Souboj(p, troll);

            if (p.health <= 0)
            {
                pismo.psani("\nTroll tě omráčil svým kyjem. Porazil jsi trolla!", 50, ConsoleColor.White); Console.ReadKey();
                return;
            }

            Console.Clear();

            pismo.psani("Za záchranu školy před trollem získáte spoustu bodů. Uběhlo několik měsíců a blíží se konec školního roku.", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\n--- HODINA KOUZELNÝCH FORMULÍ ---", 50, ConsoleColor.Cyan); Console.WriteLine();
            pismo.psani("\nProfesor Kratiknot: Dnes se naučíme pokročilé odzbrojovací kouzlo - Expelliarmus! Bude se vám hodit při obraně.", 50, ConsoleColor.White); Console.WriteLine();

            if (m.TimingKulicka(45) == 1)
            {
                pismo.psani("\nSkvěle! Naučil ses mocný Expelliarmus.", 50, ConsoleColor.Green); Console.WriteLine();
                p.mojeKouzla.Add(new Kouzlo("Expelliarmus", 22, 10));
            }
            else
            {
                pismo.psani("\nKouzlo jsi sice zvládl, ale tvoje verze je o něco slabší.", 50, ConsoleColor.Red); Console.WriteLine();
                p.mojeKouzla.Add(new Kouzlo("Expelliarmus", 15, 10));
            }
            pismo.psani("\nZmáčkni klávesu pro vstup do podzemních komnat ke Kameni mudrců...", 50, ConsoleColor.Gray); Console.ReadKey();

            Console.Clear();

            pismo.psani("Prošel jsi přes nastražené pasti v podzemí a dorazil jsi do poslední komnaty s Erisedovým zrcadlem.", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nU zrcadla stojí profesor Quirrell, ale když si sundá turban, spatříš na zátylku jeho hlavy děsivou tvář...", 50, ConsoleColor.Gray); Console.WriteLine();
            pismo.psani("\nLord Voldemort: 'Zase se potkáváme... Dej mi Kámen mudrců, nebo zemřeš!'", 50, ConsoleColor.Magenta); Console.WriteLine();

            p.health = 100;
            p.mana = p.maxmana;

            pismo.psani("\nTvoje HP a Mana byly obnoveny na maximum před finální bitvou!", 50, ConsoleColor.Yellow); Console.WriteLine();
            pismo.psani("\nZmáčkni klávesu pro FINÁLNÍ SOUBOJ!", 50, ConsoleColor.Gray); Console.ReadKey();

            Bytost boss = new Bytost();
            boss.name = "Lord Voldemort";
            boss.health = 350;

            b.Souboj(p, boss);

            Console.Clear();
            if (p.health > 0)
            {
                pismo.psani("=== VÍTĚZSTVÍ! ===", 60, ConsoleColor.Yellow); Console.WriteLine();
                pismo.psani($"\nPorazil jsi Voldemorta! Kámen mudrců je v bezpečí a tvoje kolej {p.kolej} vyhrává školní pohár!", 50, ConsoleColor.Yellow); Console.WriteLine();
            }
            else
            {
                pismo.psani("=== PORÁŽKA ===", 60, ConsoleColor.Red); Console.WriteLine();
                pismo.psani("\nVoldemort tě porazil a získal Kámen mudrců. Svět čarodějů zahalila temnota...", 50, ConsoleColor.Red); Console.WriteLine();
            }

            Console.WriteLine("\nKONEC HRY. Děkujeme za hraní!");
            Console.ReadKey();
        }
    }
}