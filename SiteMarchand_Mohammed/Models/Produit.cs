using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteMarchand_ME.Models
{
    public class Produit
    {
        private int produitId;

        public int ProduitId
        {
            get { return produitId; }
            set { produitId = value; }
        }

        private string nomProduit;

        [Display(Name = "Nom du produit")]
        public string NomProduit
        {
            get { return nomProduit; }
            set { nomProduit = value; }
        }

        private decimal prix;
        [Display(Name = "Prix du produit")]
        public decimal Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        private string description;
        [Display(Name = "Description du produit")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string categorie;

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        private int stock;
        [Required]
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int? CatalogueId { get; set; }
        [Display(Name = "Nom du Catalogue")]
        public virtual Catalogue catalogue { get; set; }

        public virtual ICollection<Promotion> promotions { get; set; }
        public virtual ICollection<HistoriqueUtilisateurProduit> historiquesProduitUtilisateur { get; set; }
        public virtual ICollection<AvisClientProduit> avisProduitClient { get; set; }
        public virtual ICollection<ProduitCommande> produitCommande { get; set; }
    }
}