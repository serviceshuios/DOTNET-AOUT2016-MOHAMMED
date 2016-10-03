using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    public class Adresse
    {
        public int AdresseId { get; set; }
        public string NumeroRue { get; set; }
        public string NomRue { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public enum TypeAdresse { Livraison, Facturation };
        public TypeAdresse typeadresse { get; set; }

        public virtual ICollection<AdresseClient> adresseClients { get; set; }
    }
}