using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HraSK1
{
    internal class Prace_ze_souborem
    {
        public string[] Cteni_ze_souboru(string nazevsouboru)
        {
            string[] Vety = new string[20];
            int i = 0;

            using (StreamReader sr = new StreamReader(nazevsouboru))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Vety[i] = s;
                    i++;
                }
            return Vety;
            }
        }
    }
}
