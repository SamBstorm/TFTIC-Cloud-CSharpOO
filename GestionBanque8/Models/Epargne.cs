using GestionBanque8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque8.Models
{
    public class Epargne : Compte
    {
        
        #region Attributs + auto prop's
        public DateTime DernierRetrait { get; private set; }
        #endregion

        #region Constructeur
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        } 
        #endregion

        #region Méthodes
        public override void Retrait(double montant)
        {
            double ancienSolde = Solde;
            base.Retrait(montant);

            if (Solde != ancienSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }

        #endregion
    }
}
