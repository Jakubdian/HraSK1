using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HraSK1
{
    internal class Psani
    {
        public void psani(string text, int delay, ConsoleColor barvatext)
        {
            foreach (char c in text)
            {
                Console.ForegroundColor = barvatext;
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}
