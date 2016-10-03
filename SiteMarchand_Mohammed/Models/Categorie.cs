using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteMarchand_ME.Models
{
    public class Categorie
    {
        private int categorieId;

        public int CategorieId
        {
            get { return categorieId; }
            set { categorieId = value; }
        }

        private string nomCategorie;
        [Display(Name = "Nom de la catégorie")]
        public string NomCategorie
        {
            get { return nomCategorie; }
            set { nomCategorie = value; }
        }

        public virtual ICollection<Produit> Produits { get; set; }
    }
}