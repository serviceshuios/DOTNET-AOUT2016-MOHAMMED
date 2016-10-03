using SiteMarchand_ME.Models;
using System.Data.Entity;

namespace SiteMarchand_ME.Dao
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("BDD_FilRouge_ME")
        {

        }

        public DbSet<Abonnement> abonnements { get; set; }
        public DbSet<AbonnementClient> abonnementClients { get; set; }
        public DbSet<Adresse> adresses { get; set; }
        public DbSet<AdresseClient> adresseClients { get; set; }
        public DbSet<Anniversaire> anniversaires { get; set; }
        public DbSet<AnniversaireClient> anniversaireClients { get; set; }
        public DbSet<AvisClientProduit> avisClientProduits { get; set; }
        public DbSet<Catalogue> catalogues { get; set; }
        public DbSet<Commande> commandes { get; set; }
        public DbSet<CommandeProduit> commandeProduits { get; set; }
        public DbSet<Fidelite> fidelites { get; set; }
        public DbSet<FideliteClient> fideliteClients { get; set; }
        public DbSet<HistoriqueUtilisateurProduit> historiqueUtilisateurProduits { get; set; }
        public DbSet<MoyenPaiement> moyenPaiements { get; set; }
        public DbSet<Panier> paniers { get; set; }
        public DbSet<Produit> produits { get; set; }
        public DbSet<ProduitCommande> produitCommandes { get; set; }
        public DbSet<Promotion> promotions { get; set; }
        public DbSet<StatutCommande> statutCommandes { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }
    }
}