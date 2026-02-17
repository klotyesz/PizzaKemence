using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
    internal class Futar
    {
        private Kemence kemence;
        int bevetel = 0;
        public Futar(Kemence kemence)
        {
            this.kemence = kemence;
        }

        public void Futtat()
        {
            while (true)
            {
                Thread.Sleep(3000);
                Pizza feladat = kemence.Kivesz();
                bevetel += feladat.Ar;
                Console.WriteLine($"Kiszállítva: {feladat} Bevétel: {bevetel}");
            }
        }
    }
}
