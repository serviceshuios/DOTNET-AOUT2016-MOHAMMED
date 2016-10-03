using System.ComponentModel.DataAnnotations;

namespace SiteMarchand_ME.Models
{
    public class ProduitCatalogueModel
    {
        public int ProduitId { get; set; }
        [Display(Name="Nom du produit")]
        public string NomProduit { get; set; }
        public decimal Prix { get; set; }
        public int Stock { get; set; }
        public string Categorie { get; set; }
        [Display(Name ="Nom du Catalogue")]
        public string NomCatalogue { get; set; }

    }
}