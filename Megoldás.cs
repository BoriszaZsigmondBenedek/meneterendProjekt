using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace meneterendProjekt
{
    internal class Megoldás
    {
        private List<Menetrend> menetrendek = new List<Menetrend>();

        public struct megálló
        {
            public int ID;
            public int Állomás;
            public TimeSpan duration;
        }

        public int ÁllomásDb => (from x in menetrendek select x.Állomás).Distinct().Count();
        public int VonatokSzáma => (from x in menetrendek select x.ID).Distinct().Count();

        public megálló leghosszabbMegálló => menetrendek
        .GroupBy(s => new { s.ID, s.Állomás })
        .Select(g =>
        {
            var erk = g.FirstOrDefault(s => s.Irány == "E");
            var ind = g.FirstOrDefault(s => s.Irány == "I");

            if (erk != null && ind != null)
            {
                TimeSpan erkIdo = new TimeSpan(erk.Óra, erk.Perc, 0);
                TimeSpan indIdo = new TimeSpan(ind.Óra, ind.Perc, 0);

                return new megálló
                {
                    ID = g.Key.ID,
                    Állomás = g.Key.Állomás,
                    duration = indIdo - erkIdo
                };
            }
            return default(megálló);
        })
        .Where(x => x.duration != TimeSpan.Zero)
        .OrderByDescending(x => x.duration)
        .FirstOrDefault();

        public void keses(int id)
        {
            var vonalmenete = menetrendek
            .Where(r => r.ID == id)
            .OrderBy(r => r.Óra)
            .ThenBy(r => r.Perc)
            .ToList();

            var first = vonalmenete.First();
            var last = vonalmenete.Last();

            TimeSpan vonalhossz = new TimeSpan(last.Óra, last.Perc, 0) - new TimeSpan(first.Óra, first.Perc, 0);
            TimeSpan tervezetthossz = new TimeSpan(2, 22, 0);

            // Compare the duration
            if (vonalhossz < tervezetthossz)
            {
                TimeSpan kulonbsseg = tervezetthossz - vonalhossz;
                Console.WriteLine($"A(z) {id}. vonat útja {kulonbsseg}-el rövidebb volt az előírtnál.");
            }
            else if (vonalhossz > tervezetthossz)
            {
                TimeSpan kulonbseg = vonalhossz - tervezetthossz;
                Console.WriteLine($"A(z) {id}. vonat útja {kulonbseg}-el hosszabb volt az előírtnál.");
            }
            else
            {
                Console.WriteLine($"A(z) {id}. vonat útja pontosan az előírt ideig tartott.");
            }
        }



        public Megoldás(string állományNeve)
        {
            if (!File.Exists(állományNeve))
            {
                Console.WriteLine($"Error: File '{állományNeve}' not found.");
                return;
            }

            string jsonContent = File.ReadAllText(állományNeve);

            var rawData = JsonConvert.DeserializeObject<List<List<object>>>(jsonContent);

            foreach (var sor in rawData)
            {
                string sorStr = string.Join(";", sor); 
                menetrendek.Add(new Menetrend(sorStr)); 
            }
        }

    }
}
