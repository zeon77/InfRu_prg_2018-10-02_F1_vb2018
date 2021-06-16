using System;

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
            Város = tmp[0];
            Név = tmp[1];
            AltNév = tmp[2];
            Férőhely = int.Parse(tmp[3]);
        }
    }
}
