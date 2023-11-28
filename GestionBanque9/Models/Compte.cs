using GestionBanque9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque9.Exceptions;

namespace GestionBanque9.Models
{
    public abstract class Compte : IBanker
    {
        #region Atributs + auto prop's

        public string Numero { get; private set; } = string.Empty;
        public double Solde { get; private set; }
        public Personne Titulaire { get; private set; }

        #endregion

        #region Constructeurs

        public Compte(string numero, Personne titulaire)
        {
            this.Numero = numero;
            Titulaire = titulaire;
        }

        public Compte(string numero, Personne titulaire, double solde) : this(numero, titulaire)
        {
            Solde = solde;
        }
        #endregion

        #region Méthodes

        public static double operator +(double solde, Compte c)
        {
            // ternaire
            return solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }

        // Retrait : Courant
        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (montant <= 0)
            {
                //Attention pas de Console.WriteLine() dans une class prévu pour du multiplateforme
                //Console.WriteLine("Le montant doit être supérieur a zéro !");

                //Envoyons un message grâce à l'exception!
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant doit être supérieur a zéro !");
            }

            if (Solde - montant <= ligneDeCredit)
            {
                //Attention pas de Console.WriteLine() dans une class prévu pour du multiplateforme
                //Console.WriteLine("Solde insufissant !");

                throw new SoldeInsuffisantException(Solde, montant, ligneDeCredit);
            }

            Solde -= montant;
        }

        // Retrait : Epargne
        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0.0);
        }

        // Dépôt
        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                //Attention pas de Console.WriteLine() dans une class prévu pour du multiplateforme
                //Console.WriteLine("Le montant doit être supérieur a zéro !");

                //Envoyons un message grâce à l'exception!
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant doit être supérieur a zéro !");
            }
            Solde += montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        #endregion
    }
}
