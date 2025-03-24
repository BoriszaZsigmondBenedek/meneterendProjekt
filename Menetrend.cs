using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace meneterendProjekt
{
    internal class Menetrend
    {
        public int ID { get;  set; }
        public int Állomás { get;  set; }
        public int Óra { get;  set; }
        public int Perc { get;  set; }
        public string Irány  { get;  set; }


        public static List<Menetrend> ReadFromJson(string forrás)
        {
            string jsonString = File.ReadAllText(forrás);
            return JsonConvert.DeserializeObject<List<Menetrend>>(jsonString);
        }

    }

}
