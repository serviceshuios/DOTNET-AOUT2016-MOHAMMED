using System.Collections.Generic;
using SiteMarchand_ME.Dao;

namespace SiteMarchand_ME.Models
{
    public class AdministrateurImpl: IAdministrateur
    {
        IDao idao = new DaoImpl();

        /* ******************************* Compte ******************************* */
        public Utilisateur AfficherCompte(int IdUtilisateur)
        {
            return idao.AfficherCompte(IdUtilisateur);
        }

        public Administrateur CreationCompteAdmin(Administrateur a)
        {
            return idao.CreationCompteAdmin(a);
        }

        public void SuppressionCompte(int IdUtilisateur)
        {
            idao.SuppressionCompte(IdUtilisateur);
        }

        public ICollection<Utilisateur> ListerComptes()
        {
            return idao.ListerComptes();
        }
        public Utilisateur ConnexionCompte(Utilisateur ut)
        {
            return idao.ConnexionCompte(ut);
        }

        /* ******************************* Produit ******************************* */
        public Produit AjouterProduit(Produit p)
        {
            return idao.AjouterProduit(p);
        }

        public void SupprimerProduit(int IdProduit)
        {
            idao.SupprimerProduit(IdProduit);
        }

        public ICollection<Produit> ListerProduits()
        {
            return idao.ListerProduits();
        }

        public Produit ModifierProduit(Produit p)
        {
            return idao.ModifierProduit(p);
        }

        public Produit AfficherProduit(int IdProduit)
        {
            return idao.AfficherProduit(IdProduit);
        }

        public ICollection<Produit> RechercherProduitsParNom(string nom)
        {
            return idao.RechercherProduitsParNom(nom);
        }

        public ICollection<Produit> RechercherProduitParId(int idProduit)
        {
            return idao.RechercherProduitParId(idProduit);
        }

        /* ******************************* Adresse ******************************* */

        public ICollection<AdresseClientModel> ListerAdresseClient()
        {
            return idao.ListerAdresseClient();
        }

        /* ******************************* Promotion ******************************* */

        public Promotion CreerPromotion(Promotion p)
        {
            return idao.CreerPromotion(p);
        }

        public void SupprimerPromotion(int PromotionId)
        {
            idao.SupprimerPromotion(PromotionId);
        }

        public Promotion ModifierPromotion(Promotion p)
        {
            return idao.ModifierPromotion(p);
        }

        /* ******************************* Catalogue ******************************* */

        public Catalogue AjouterCatalogue(Catalogue c)
        {
            return idao.AjouterCatalogue(c);
        }

        public void SupprimerCatalogue(int CatalogueId)
        {
            idao.SupprimerCatalogue(CatalogueId);
        }

        public ICollection<Catalogue> ListerCatalogue()
        {
            return idao.ListerCatalogue();
        }

        public ICollection<ProduitCatalogueModel> ListerProduitCatalogue()
        {
            return idao.ListerProduitCatalogue();
        }

        /* ******************************* Abonnement ******************************* */

        public Abonnement CreerAbonnement(Abonnement a)
        {
            return idao.CreerAbonnement(a);
        }

        public void SupprimerAbonnement(int IdAbonnement)
        {
            idao.SupprimerAbonnement(IdAbonnement);
        }

        public ICollection<Abonnement> ListerTousAbonnements()
        {
            return idao.ListerTousAbonnements();
        }
    }
}