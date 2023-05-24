using ConsoleApp7;
using System;

namespace ConsoleApp7 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Muvelet> muveletek = new List<Muvelet>(); 

            File.ReadAllLines("kifejezesek.txt").ToList().ForEach(x => muveletek.Add(new Muvelet(x)));
            Console.WriteLine(muveletek);
            Console.WriteLine($"2.feladat: Kifejezések száma: {muveletek.Count()}");
            Console.WriteLine($"3.feladat: Kifejezések maradékos osztással: {muveletek.Count(x => x.Jel == "mod")}");
            Console.Write("4.feladat: ");
            Console.WriteLine(muveletek.Any(x => x.ElsoSzam % 10 == 0 && x.MasodikSzam % 10 == 0) ? "Van ilyen kifejezés!" : "Nincs ilyen kifejezés.");
            Console.WriteLine("5.feladat: Statisztika");
            List<string> keresettJelek = new List<string> {"mod", "/", "div", "-", "*", "+"};
            muveletek.Where(x => keresettJelek.Contains(x.Jel)).GroupBy(x => x.Jel).ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Count()} db".PadLeft(20)));
        }
    }
}
