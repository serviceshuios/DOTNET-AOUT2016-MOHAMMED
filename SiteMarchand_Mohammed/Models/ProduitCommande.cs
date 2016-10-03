using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class ProduitCommande
    {
        [Key, Column(Order = 0)]
        public int ProduitId { get; set; }
        [Key, Column(Order = 1)]
        public int CommandeId { get; set; }

        public virtual Produit produit { get; set; }
        public virtual Commande commande { get; set; }

        public int PanierId { get; set; }
        public virtual Panier panier { get; set; }

        public int quantite { get; set; }
        public int promotion { get; set; }
    }
}