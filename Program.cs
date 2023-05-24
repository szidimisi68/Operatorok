using ConsoleApp7;
using System;

namespace ConsoleApp7
{
    class Program
    {
        static string Szamol(List<string> jelek, Muvelet muvelet)
        {
            if (!jelek.Contains(muvelet.Jel))
            {
                return "Hibás operátor!";
            }

            try
            {
                switch (muvelet.Jel)
                {
                    case "mod":
                        return Convert.ToString(muvelet.ElsoSzam % muvelet.MasodikSzam);
                    case "/":
                        return Convert.ToString(muvelet.ElsoSzam / muvelet.MasodikSzam*1.0);
                    case "div":
                        return Convert.ToString(muvelet.ElsoSzam / muvelet.MasodikSzam);
                    case "-":
                        return Convert.ToString(muvelet.ElsoSzam - muvelet.MasodikSzam);
                    case "*":
                        return Convert.ToString(muvelet.ElsoSzam * muvelet.MasodikSzam);
                    case "+":
                        return Convert.ToString(muvelet.ElsoSzam + muvelet.MasodikSzam);
                    default:
                        break;
                }
            }
            
            catch (Exception)
            {
                return "Egyéb hiba!";
            }
            return "";
        }


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

            string bekeres = "";
            while (bekeres != "vége")
            {
                Console.Write($"7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                bekeres = Console.ReadLine();
                if (bekeres != "vége")
                {
                    Console.WriteLine($"\t{bekeres} = {Szamol(keresettJelek, new Muvelet(bekeres))}");
                }
            }
            List<string> sorok = new List<string>();
            muveletek.ForEach(x => sorok.Add($"{x.ElsoSzam} {x.Jel} {x.MasodikSzam} = {Szamol(keresettJelek, x)}"));
            File.WriteAllLines("eredmenyek.txt", sorok);
            Console.WriteLine("8. feladat: eredmenyek.txt");
        }
    }
}
