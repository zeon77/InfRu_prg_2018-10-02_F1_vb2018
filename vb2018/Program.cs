using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace vb2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Stadion> stadionok = new List<Stadion>();
            foreach (var sor in File.ReadAllLines("vb2018.txt").Skip(1))
            {
                try
                {
                    stadionok.Add(new Stadion(sor));
                }
                catch { }
            }

            //3.
            Console.WriteLine("3. feladat: Stadionok száma: {0}", stadionok.Count);
        }
    }
}
