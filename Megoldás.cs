using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace meneterendProjekt
{
    internal class Megoldás
    {
        private List<Menetrend> menetrendek = new List<Menetrend>();

        public int ÁllomásDb => (from x in menetrendek select x.Állomás).Distinct().Count();
        public int VonatokSzáma => (from x in menetrendek select x.ID).Distinct().Count();



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
