using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Kouzlo
    {
        public string nazev;
        public int sila;
        public int cenamany;

        public Kouzlo(string nazev, int sila, int cena) 
        {
            this.nazev = nazev;
            this.sila = sila;
            this.cenamany = cena;
        }
    }
}
