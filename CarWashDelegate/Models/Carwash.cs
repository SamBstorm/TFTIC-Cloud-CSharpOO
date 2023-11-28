using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDelegate.Models
{
    public delegate void CarWashAction(Voiture voiture);
    public class Carwash
    {
        private CarWashAction _traitement;

        public Carwash()
        {
            /*
            _traitement = Preparer;
            _traitement += Laver;
            _traitement += Secher;
            _traitement += Finaliser;
            */

            _traitement = delegate (Voiture voiture) { Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}"); };
            _traitement += delegate (Voiture voiture) { Console.WriteLine($"Je lave la voiture : {voiture.Plaque}"); };
            _traitement += delegate (Voiture voiture) { Console.WriteLine($"Je sèche la voiture : {voiture.Plaque}"); };
            _traitement += delegate (Voiture voiture) { Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}"); };
        }
        public void Traiter(Voiture voiture)
        {
            _traitement(voiture);
        }

        /*
        private void Preparer(Voiture voiture)
        {
            Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}");
        }

        private void Laver(Voiture voiture)
        {
            Console.WriteLine($"Je lave la voiture : {voiture.Plaque}");
        }
        private void Secher(Voiture voiture)
        {
            Console.WriteLine($"Je sèche la voiture : {voiture.Plaque}");
        }
        private void Finaliser(Voiture voiture)
        {
            Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}");
        }*/
    }
}
