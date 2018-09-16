using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    /// <summary>
    /// Classe représentant un sertapil (animal de l'empereur)
    /// </summary>
    public class Sertapil
    {
        #region Méthodes publiques
        public override string ToString()
        {
            return "INSERT INTO [dbo].[Sertapil] " +
           "( " +
           ",[Nom] " +
           ",[Taille] " +
           ",[CoutNaissance]) " +
            "VALUES " +
           "( " +
           ", '" + this.Nom + "' " +
           ", " + this.Taille + " " +
           ", " + this.PrixNaissance + ") ;";
        }
        #endregion

        #region Propriétés
        /// <summary>
        /// Nom de l'animal
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Taille de l'animal
        /// </summary>
        public decimal Taille { get; set; }

        /// <summary>
        /// Prix de naissance
        /// </summary>
        public decimal PrixNaissance { get; set; }
        #endregion
    }
}
