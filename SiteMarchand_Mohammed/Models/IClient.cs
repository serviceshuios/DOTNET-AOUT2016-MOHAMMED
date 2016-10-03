using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    public interface IClient: IUtilisateur
    {
        /* ******************************* Produit ******************************* */
        //ICollection<Produit> RechercherProduitsParNom(string nom);

        ICollection<Produit> RechercherProduits(decimal PrixMin, decimal PrixMax);

        ICollection<Produit> RechercherProduitsParCategorie(string Categorie);

        //ICollection<Produit> ListerProduits();

        //ICollection<ProduitCatalogueModel> ListerProduitCatalogue();

        //Produit AfficherProduit(int IdProduit);

        /* ******************************* Compte ******************************* */

        Client CreationCompteClient(Client c);

        //Utilisateur AfficherCompte(int IdUtilisateur);

        //Utilisateur ConnexionCompte(Utilisateur ut);

        Client ModifierCompte(Client c);

        /* ******************************* Commande ******************************* */

        Commande CreerCommande(Commande c);

        Commande ModifierCommande(Commande c);

        void SupprimerCommande(int IdCommande);

        ICollection<Commande> ListerCommandes(int IdUtilisateur);

        Commande AfficherCommande(int IdCommande);

        ProduitCommande AjouterLigneCommande(ProduitCommande p);

        void SupprimerLigneCommande(int IdProduit, int IdCommande);

        ProduitCommande ModifierLigneCommande(ProduitCommande p);

        /* ******************************* Abonnement ******************************* */
        ICollection<Abonnement> ListerTousAbonnements();

        AbonnementClient AjouterAbonnementClient(AbonnementClient ac);

        ICollection<Abonnement> ListerAbonnement(int IdUtilisateur);

        /* ******************************* Adresse ******************************* */
        AdresseClient AjouterAdresseClient(AdresseClient a);

        Adresse AjouterAdresse(Adresse a);

        void SupprimerAdresse(int IdAdresse);

        ICollection<Adresse> ListerAdresse(int IdUtilisateur);

        /* **************************** Panier **************************** */
        Panier AjouterPanier(Panier p);

        void SupprimerPanier(int IdPanier);

        Panier AfficherPanier(int IdPanier);

        /* ******************************* Promotion ******************************* */
        ICollection<Promotion> ListerPromotions();
    }
}
