using System.Collections.Generic;
using SiteMarchand_ME.Dao;

namespace SiteMarchand_ME.Models
{
    public class ClientImpl: IClient
    {
        IDao idao = new DaoImpl();

        /* ******************************* Produit ******************************* */
        public ICollection<Produit> RechercherProduitsParNom(string nom)
        {
            return idao.RechercherProduitsParNom(nom);
        }

        public ICollection<Produit> RechercherProduits(decimal PrixMin, decimal PrixMax)
        {
            return idao.RechercherProduits(PrixMin, PrixMax);
        }

        public ICollection<Produit> RechercherProduitsParCategorie(string Categorie)
        {
            return idao.RechercherProduitsParCategorie(Categorie);
        }

        public ICollection<Produit> ListerProduits()
        {
            return idao.ListerProduits();
        }

        public ICollection<ProduitCatalogueModel> ListerProduitCatalogue()
        {
            return idao.ListerProduitCatalogue();
        }

        public Produit AfficherProduit(int IdProduit)
        {
            return idao.AfficherProduit(IdProduit);
        }

        /* ******************************* Compte ******************************* */

        public Client CreationCompteClient(Client c)
        {

            return idao.CreationCompteClient(c);
        }

        public Utilisateur AfficherCompte(int IdUtilisateur)
        {
            return idao.AfficherCompte(IdUtilisateur);
        }

        public Utilisateur ConnexionCompte(Utilisateur ut)
        {
            return idao.ConnexionCompte(ut);
        }

        public Client ModifierCompte(Client c)
        {
            return idao.ModifierCompte(c);
        }

        /* ******************************* Commande ******************************* */

        public Commande CreerCommande(Commande c)
        {
            return idao.CreerCommande(c);
        }

        public Commande ModifierCommande(Commande c)
        {
            return idao.ModifierCommande(c);
        }

        public void SupprimerCommande(int IdCommande)
        {
            idao.SupprimerCommande(IdCommande);
        }

        public ICollection<Commande> ListerCommandes(int IdUtilisateur)
        {
            return idao.ListerCommandes(IdUtilisateur);
        }

        public Commande AfficherCommande(int IdCommande)
        {
            return idao.AfficherCommande(IdCommande);
        }

        public ProduitCommande AjouterLigneCommande(ProduitCommande p)
        {
            return idao.AjouterLigneCommande(p);
        }

        public void SupprimerLigneCommande(int IdProduit, int IdCommande)
        {
            idao.SupprimerLigneCommande(IdProduit, IdCommande);
        }

        public ProduitCommande ModifierLigneCommande(ProduitCommande p)
        {
            return idao.ModifierLigneCommande(p);
        }

        /* ******************************* Abonnement ******************************* */
        public ICollection<Abonnement> ListerTousAbonnements()
        {
            return idao.ListerTousAbonnements();
        }

        public AbonnementClient AjouterAbonnementClient(AbonnementClient ac)
        {
            return idao.AjouterAbonnementClient(ac);
        }

        public ICollection<Abonnement> ListerAbonnement(int IdUtilisateur)
        {
            return idao.ListerAbonnement(IdUtilisateur);
        }

        /* ******************************* Adresse ******************************* */
        public AdresseClient AjouterAdresseClient(AdresseClient a)
        {
            return idao.AjouterAdresseClient(a);
        }

        public Adresse AjouterAdresse(Adresse a)
        {
            return idao.AjouterAdresse(a);
        }

        public void SupprimerAdresse(int IdAdresse)
        {
            idao.SupprimerAdresse(IdAdresse);
        }

        public ICollection<Adresse> ListerAdresse(int IdUtilisateur)
        {
            return idao.ListerAdresse(IdUtilisateur);
        }

        /* **************************** Panier **************************** */
        public Panier AjouterPanier(Panier p)
        {
            return idao.AjouterPanier(p);
        }

        public void SupprimerPanier(int IdPanier)
        {
            idao.SupprimerPanier(IdPanier);
        }

        public Panier AfficherPanier(int IdPanier)
        {
            return idao.AfficherPanier(IdPanier);
        }

        /* ******************************* Promotion ******************************* */
        public ICollection<Promotion> ListerPromotions()
        {
            return idao.ListerPromotions();
        }
    }
}