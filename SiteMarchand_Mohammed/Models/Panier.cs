using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class Panier
    {
        public int PanierId { get; set; }
        public int NombreProduits { get; set; }
        [Column("Prixtotal", TypeName = "money")]
        public decimal PrixTotal { get; set; }


        public virtual ICollection<ProduitCommande> produitCommandes { get; set; }
    }
}