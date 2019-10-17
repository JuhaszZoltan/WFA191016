using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA191016
{
    class Vendeg
    {
        public string Nev { get; set; }
        public bool Fiu { get; set; }
        public int Asztal { get; set; }
        public bool Vega { get; set; }

        public Vendeg(string sor)
        {
            var t = sor.Split(';');
            Nev = t[0];
            Fiu = t[1] == "m";
            Asztal = int.Parse(t[2]);
            Vega = t[3] == "v";
        }
    }
}
