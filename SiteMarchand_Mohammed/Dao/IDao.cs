using SiteMarchand_ME.Models;
using System.Collections.Generic;

namespace SiteMarchand_ME.Dao
{
    public interface IDao
    {
        /* ******************************* Compte ******************************* */
        Utilisateur AfficherCompte(int IdUtilisateur);

        Utilisateur ConnexionCompte(Utilisateur ut);

        Administrateur CreationCompteAdmin(Administrateur a);

        Client CreationCompteClient(Client c);

        void SuppressionCompte(int IdUtilisateur);

        ICollection<Utilisateur> ListerComptes();

        Client ModifierCompte(Client c);

        /* **************************** Utilisateur **************************** */
        Utilisateur ModifierUtilisateur(Utilisateur u);

        ICollection<Utilisateur> ListerAdministrateur();

        ICollection<Utilisateur> ListerClient();

        Utilisateur RechercherUtilisateurParId(int IdUtilisateur);

        ICollection<Utilisateur> RechercherUtilisateurParNom(string nom);

        /* ******************************* Commande ******************************* */
        Commande CreerCommande(Commande c);

        void SupprimerCommande(int IdCommande);

        Commande ModifierCommande(Commande c);

        ProduitCommande AjouterLigneCommande(ProduitCommande p);

        void SupprimerLigneCommande(int IdProduit, int IdCommande);

        ProduitCommande ModifierLigneCommande(ProduitCommande p);

        Commande AfficherCommande(int IdCommande);

        ICollection<Commande> ListerCommandes(int IdUtilisateur);

        /* ******************************* Produit ******************************* */
        Produit AjouterProduit(Produit p);

        void SupprimerProduit(int IdProduit);

        ICollection<Produit> RechercherProduitsParNom(string nom);

        ICollection<Produit> RechercherProduits(decimal prixMin, decimal prixMax);

        ICollection<Produit> RechercherProduitsParCategorie(string Categorie);

        Produit ModifierProduit(Produit p);

        ICollection<Produit> ListerProduits();

        Produit AfficherProduit(int IdProduit);

        ICollection<Produit> RechercherProduitParId(int idProduit);


        /* ******************************* Catalogue ******************************* */
        Catalogue AjouterCatalogue(Catalogue c);

        void SupprimerCatalogue(int IdCatalogue);

        Catalogue AfficherCatalogue(int IdCatalogue);

        ICollection<Catalogue> ListerCatalogue();

        ICollection<ProduitCatalogueModel> ListerProduitCatalogue();

        /* ******************************* Promotion ******************************* */
        Promotion CreerPromotion(Promotion p);

        void SupprimerPromotion(int IdPromotion);

        Promotion ModifierPromotion(Promotion p);

        Promotion AfficherPromotion(int IdPromotion);

        ICollection<Promotion> ListerPromotions();

        /* ******************************* Avis ******************************* */
        AvisClientProduit AjouterAvis(AvisClientProduit com);

        AvisClientProduit AfficherAvis(int IdUtilisateur, int IdProduit);

        void SupprimerAvis(int IdUtilisateur, int IdProduit);

        AvisClientProduit ModifierAvis(AvisClientProduit com);

        /* ******************************* Adresse ******************************* */
        Adresse AjouterAdresse(Adresse a);

        void SupprimerAdresse(int IdAdresse);

        Adresse AfficherAdresse(int IdAdresse);

        Adresse ModifierAdresse(Adresse a);

        AdresseClient AjouterAdresseClient(AdresseClient a);

        ICollection<Adresse> ListerAdresse(int IdUtilisateur);

        ICollection<AdresseClientModel> ListerAdresseClient();

        /* ******************************* Abonnement ******************************* */
        Abonnement AjouterAbonnement(Abonnement a);

        void SupprimerAbonnement(int IdAbonnement);

        Abonnement CreerAbonnement(Abonnement a);

        Abonnement AfficherAbonnement(int IdAbonnement);

        ICollection<Abonnement> ListerAbonnement(int IdUtilisateur);

        AbonnementClient AjouterAbonnementClient(AbonnementClient ac);

        ICollection<Abonnement> ListerTousAbonnements();

        void SupprimerAbonnementClient(int IdAbonnement, int IdUtilisateur);

        /* **************************** Panier **************************** */
        Panier AjouterPanier(Panier p);

        void SupprimerPanier(int IdPanier);

        Panier AfficherPanier(int IdPanier);

    }
}
