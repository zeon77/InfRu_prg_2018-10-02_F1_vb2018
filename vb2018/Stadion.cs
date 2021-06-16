using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vb2018
{
    class Stadion
    {
        public string Város { get; set; }
        public string Név { get; set; }
        public string AltNév { get; set; }
        public int Férőhely { get; set; }

        public Stadion(string sor)
        {
            string[] tmp = sor.Split(';');
            this.Város = tmp[0];
            this.Név = tmp[1];
            this.AltNév = tmp[2];
            this.Férőhely = int.Parse(tmp[3]);
        }
    }
}
