using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class Avis
    {
        [Key, Column(Order = 0)]
        public int ClientId { get; set; }
        [Key, Column(Order = 1)]
        public int ProduitId { get; set; }

        private int star;
        [Required]
        public int Star
        {
            get { return star; }
            set { star = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public virtual Client client { get; set; }
        public virtual Produit produit { get; set; }
    }
}