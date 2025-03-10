using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meneterendProjekt
{
    internal class Menetrend
    {
        public int ID { get; private set; }
        public int Állomás { get; private set; }
        public int Óra { get; private set; }
        public int Perc { get; private set; }
        public string Irány  { get; private set; }


        public Menetrend(string adatsor)
        {
            string[] m = adatsor.Split(';');
            ID = int.Parse(m[0]);
            Állomás = int.Parse(m[1]);
            Óra = int.Parse(m[2]);
            Perc = int.Parse(m[3]);
            Irány = m[4];
        }

    }

}
