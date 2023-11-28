using CarWashDelegate.Models;

namespace CarWashDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("1-ABC-123");
            Voiture v2 = new Voiture("2-ABC-123");
            Voiture v3 = new Voiture("D-ABC-123");

            Carwash carwash = new Carwash();

            carwash.Traiter(v1);
            carwash.Traiter(v2);
            carwash.Traiter(v3);
        }
    }
}