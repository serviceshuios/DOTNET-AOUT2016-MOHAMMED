using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    public class StatutCommande
    {
        public int StatutCommandeId { get; set; }
        public enum TypeCommande { EnCours, EnAttente, Abandonné, Terminée };
        public TypeCommande typeCommande { get; set; }

        public virtual ICollection<Commande> commandes { get; set; }

        
    }
}