using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
    internal class Sef
    {
        private Kemence kemence;

        private static Random r = new Random();
        private static string[] nevek = { "Magyaros", "Sajtos", "Texsas", "Sonkás", "Gyrosos" };
        public Sef(Kemence kemence)
        {
            this.kemence = kemence;
        }
        public void Futtat()
        {
            while (true)
            {
                Thread.Sleep(2000);
                string nev = nevek[r.Next(0, nevek.Length)];
                int meret = r.Next(16, 48);
                Pizza feladat = new Pizza(nev, meret);

                kemence.Hozzaad(feladat);
                Console.WriteLine($"A séf leadta az alábbi piizát: {feladat}");
            }
        }
    }
}
