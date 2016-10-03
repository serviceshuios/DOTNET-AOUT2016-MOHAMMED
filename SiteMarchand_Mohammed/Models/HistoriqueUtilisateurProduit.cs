using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class HistoriqueUtilisateurProduit
    {
        [Key, Column(Order = 0)]
        public int UtilisateurId { get; set; }
        [Key, Column(Order = 1)]
        public int ProduitId { get; set; }

        public virtual Utilisateur utilisateur { get; set; }
        public virtual Produit produit { get; set; }

        public DateTime DateConsultation { get; set; }
    }
}