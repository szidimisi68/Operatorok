using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Muvelet
    {
        double elsoSzam;
        string jel;
        double masodikSzam;

        public Muvelet(string adatSor)
        {
            string[] felbontottSor = adatSor.Split(" ");
            this.elsoSzam = double.Parse(felbontottSor[0]);
            this.jel = felbontottSor[1];
            this.masodikSzam = double.Parse(felbontottSor[2]);
        }


        public double ElsoSzam { get => elsoSzam; set => elsoSzam = value; }
        public string Jel { get => jel; set => jel = value; }
        public double MasodikSzam { get => masodikSzam; set => masodikSzam = value; }
    }
}
