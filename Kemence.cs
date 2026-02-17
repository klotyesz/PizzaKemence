using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
    internal class Kemence
    {
        private SzinkronPuffer<Pizza> puffer;
        public Kemence(int meret)
        {
            this.puffer = new SzinkronPuffer<Pizza>(meret);
        }

        public void Hozzaad(Pizza feladat)
        {
            puffer.Hozzaad(feladat);

        }

        public Pizza Kivesz()
        {
            return puffer.Kivesz();
        }
    }
}
