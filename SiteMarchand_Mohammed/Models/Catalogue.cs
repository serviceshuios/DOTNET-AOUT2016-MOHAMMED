using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteMarchand_ME.Models
{
    public class Catalogue
    {
        public int CatalogueId { get; set; }
        [Display(Name = "Nom du Catalogue")]
        public string Nom { get; set; }
        public virtual ICollection<Produit> produits { get; set; }
    }
}