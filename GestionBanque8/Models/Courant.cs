using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque8.Models
{
    public class Courant : Compte
    {
        #region Attriuts + auto prop's
        private double _LigneDeCredit { get; set; }
        #endregion

        #region Prop's
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            private set
            {
                if (value < 0)
                {
                    return; // à remplacer plus tard par une exception
                }

                _LigneDeCredit = value;
            }
        }
        #endregion

        #region Constructor
        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Courant(string numero, Personne titulaire, double ligneDeCredit) : base(numero, titulaire)
        {
            _LigneDeCredit = ligneDeCredit;
        }

        public Courant(string numero, Personne titulaire, double ligneDeCredit, double solde) : base(numero, titulaire, solde)
        {
            _LigneDeCredit = ligneDeCredit;
        }

        #endregion

        #region Méthodes

        public override void Retrait(double montant)
        {
            Retrait(montant, _LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            return (Solde < 0) ? Solde * 0.0975 : Solde * 0.03;
        }

        #endregion
    }
}
