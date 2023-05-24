using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Muvelet
    {
        int elsoSzam;
        string jel;
        int masodikSzam;

        public Muvelet(string adatSor)
        {
            string[] felbontottSor = adatSor.Split(" ");
            this.elsoSzam = int.Parse(felbontottSor[0]);
            this.jel = felbontottSor[1];
            this.masodikSzam = int.Parse(felbontottSor[2]);
        }


        public int ElsoSzam { get => elsoSzam; set => elsoSzam = value; }
        public string Jel { get => jel; set => jel = value; }
        public int MasodikSzam { get => masodikSzam; set => masodikSzam = value; }
    }
}
