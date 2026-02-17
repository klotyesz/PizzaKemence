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
        public Futar(Kemence nyomtato)
        {
            this.kemence = nyomtato;
        }

        public void Futtat()
        {
            while (true)
            {
                Thread.Sleep(3000);
                Pizza feladat = kemence.Kivesz();
                Console.WriteLine($"Kiszállítva: {feladat}");
            }
        }
    }
}
