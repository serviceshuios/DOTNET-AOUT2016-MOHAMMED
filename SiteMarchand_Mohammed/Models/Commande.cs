using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    public class Commande
    {
        public int CommandeId { get; set; }
        public string Commentaire { get; set; }

        public int UtilisateurId { get; set; }
        public virtual Client client { get; set; }

        //public virtual ICollection<Client> clients { get; set; }

        public int StatutCommandeId { get; set; }
        public virtual StatutCommande statut { get; set; }

        public virtual ICollection<ProduitCommande> produitCommandes { get; set; }
    }
}