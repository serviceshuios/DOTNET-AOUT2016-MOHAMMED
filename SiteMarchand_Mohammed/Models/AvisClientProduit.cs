using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class AvisClientProduit
    {
        [Key, Column(Order = 0)]
        public int UtilisateurId { get; set; }
        [Key, Column(Order = 1)]
        public int ProduitId { get; set; }

        public virtual Client client { get; set; }
        public virtual Produit produit { get; set; }

        public float Note { get; set; }
        public string Commentaire { get; set; }
    }
}