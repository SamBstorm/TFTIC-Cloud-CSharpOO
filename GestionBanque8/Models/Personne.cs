using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque8.Models
{
    public class Personne
    {
        #region Atrributs + auto prop's
        public string Nom { get; private set; } = string.Empty;
        public string Prenom { get; private set; } = string.Empty;
        public DateTime DateNaissance { get; private set; }
        #endregion

        #region Constructeurs
        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        } 
        #endregion
    }
}
