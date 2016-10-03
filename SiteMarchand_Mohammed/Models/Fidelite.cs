using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    public class Fidelite
    {
        public int FideliteId { get; set; }
        public int NombrePoints { get; set; }
        public string Avantages { get; set; }

        public int UtilisateurId { get; set; }
        public virtual ICollection<FideliteClient> fideliteClients { get; set; }
    }
}