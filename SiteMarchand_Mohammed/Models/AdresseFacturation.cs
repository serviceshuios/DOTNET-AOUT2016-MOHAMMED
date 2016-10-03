namespace SiteMarchand_ME.Models
{
    public class AdresseFacturation : Adresse
    {
        private string nomAdresseFacturation = "Nom de l'adresse de facturation";

        public string NomAdresseFacturation
        {
            get { return nomAdresseFacturation; }
            set { nomAdresseFacturation = value; }
        }

    }
}