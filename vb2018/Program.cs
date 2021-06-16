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

            //4.
            int minFérőhely = stadionok.Min(x => x.Férőhely);
            var minStadion = stadionok.Single(x => x.Férőhely == minFérőhely);
            Console.WriteLine("4. feladat: A legkevesebb férőhely:");
            Console.WriteLine("\t Város: {0}", minStadion.Város);
            Console.WriteLine("\t Stadion neve: {0}", minStadion.Név);
            Console.WriteLine("\t Férőhely: {0}", minStadion.Férőhely);

            //5.
            Console.WriteLine($"5. feladat: Átlagos férőhelyszám: " +
                $"{stadionok.Average(x => x.Férőhely):0.0}");

            //6.
            Console.WriteLine($"6. feladat: Két néven is ismert stadionok száma: " +
                $"{stadionok.Where(x => x.AltNév != "n.a.").Count()}");

            //7.
            Console.Write("7. feladat: Kérem a város nevét: ");
            string Város = Console.ReadLine();
            while (Város.Length < 3)
            {
                Console.Write("7. feladat: Kérem a város nevét (min. 3 kar.): ");
                Város = Console.ReadLine();
            }

            //8.
            Console.WriteLine($"8. feladat: A megadott város " +
                $"{(stadionok.Where(x => x.Város.ToLower().Contains(Város.ToLower())).Count() > 0 ? "" : "nem ")}" +
                $"VB helyszín");

            //9. Dictinct városok
            Console.WriteLine("9. feladat: {0} különböző városban voltak mérkőzések.", stadionok.GroupBy(x => x.Város).Count());
        }
    }
}
