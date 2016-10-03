namespace SiteMarchand_ME.Models
{
    public class AdresseLivraison : Adresse
    {
        private string nomAdresseLivraison = "Nom de l'adresse de livraison";

        public string NomAdresseLivraison
        {
            get { return nomAdresseLivraison; }
            set { nomAdresseLivraison = value; }
        }
    }
}