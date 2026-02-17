namespace PizzaKemence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kemence kemence = new Kemence(5);

            Sef sef = new Sef(kemence);
            Futar futar = new Futar(kemence);

            Thread sefSzal = new Thread(sef.Futtat);
            Thread futarSzal = new Thread(futar.Futtat);

            sefSzal.Start();
            futarSzal.Start();
        }
    }
}
