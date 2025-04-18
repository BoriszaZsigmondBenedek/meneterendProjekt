﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meneterendProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string forras = "adat.json";
            Megoldás m = new Megoldás(forras);

            Console.WriteLine($"2. feladat\nAz állomások száma: {m.ÁllomásDb}\nA vonatok száma: {m.VonatokSzáma}\n");
            Console.WriteLine($"3. feladat\nA (z) {m.leghosszabbMegálló.ID}. vonat a (z) {m.leghosszabbMegálló.Állomás}. állomáson {m.leghosszabbMegálló.duration} (óra, perc)-et állt.\n");
            Console.Write("4. feladat\nAdja meg egy vonat azonosítóját! ");
            int bekertvonat = int.Parse(Console.ReadLine());
            Console.Write("Adjon meg egy időpontot (óra perc) !");
            string bekertido = Console.ReadLine();
            m.keses(bekertvonat);
            m.menetrendfajlba(bekertvonat);
            m.vonatokmenetkozben(bekertido);
            
        }
    }
}
