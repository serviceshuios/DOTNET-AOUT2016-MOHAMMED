using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class LigneCommande
    {
        [Key, Column(Order = 0)]
        public int CommandeId { get; set; }
        [Key, Column(Order = 1)]
        public int ProduitId { get; set; }

        public int PanierId { get; set; }

        public virtual Panier panier { get; set; }

        public virtual Commande commande { get; set; }
        public virtual Produit produit { get; set; }
    }
}
