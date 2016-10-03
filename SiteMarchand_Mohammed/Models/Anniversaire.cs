using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    public class Anniversaire
    {
        public int AnniversaireId { get; set; }
        public bool Actif { get; set; }
        public bool Utilise { get; set; }

        public virtual ICollection<AnniversaireClient> anniversaireClients { get; set; }
    }
}