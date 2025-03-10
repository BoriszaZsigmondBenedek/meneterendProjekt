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

        public megálló leghosszabbMegálló => menetrendek.GroupBy(s => new { s.ID, s.Állomás }).Select(g =>
        {
            var erk = g.FirstOrDefault(s => s.Irány == "E");
            var ind = g.FirstOrDefault(s => s.Irány == "I");
            megálló stop;

            if (erk != null && ind != null)
            {
                TimeSpan erkIdo = new TimeSpan(erk.Óra, erk.Perc, 0);
                TimeSpan indIdo = new TimeSpan(ind.Óra, ind.Perc, 0);
                stop.ID = g.Key.ID;
                stop.Állomás = g.Key.Állomás;
                stop.duration = indIdo - erkIdo;

                return stop;
            }
            return 0;
        }).Where(x => x != 0).OrderByDescending(x => x.duration);



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
