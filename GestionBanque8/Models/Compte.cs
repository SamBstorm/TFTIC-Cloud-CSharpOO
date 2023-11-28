using GestionBanque8.Models;
using GestionBanque7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque8.Models
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
                Console.WriteLine("Le montant doit être supérieur a zéro !");
                return; // à remplacer par une exception
            }

            if (Solde - montant <= ligneDeCredit)
            {
                Console.WriteLine("Solde insufissant !");
                return; // à remplacer par une exception
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
                Console.WriteLine("Le montant doit être supérieur a zéro !");

                return; // à remplacer par une exception
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
