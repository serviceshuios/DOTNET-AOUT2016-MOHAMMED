using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    interface IAdministrateur: IUtilisateur
    {
        /* ******************************* Compte ******************************* */
        //Utilisateur AfficherCompte(int IdUtilisateur);

        Administrateur CreationCompteAdmin(Administrateur a);

        void SuppressionCompte(int IdUtilisateur);

        ICollection<Utilisateur> ListerComptes();

        //Utilisateur ConnexionCompte(Utilisateur ut);

        /* ******************************* Produit ******************************* */
        Produit AjouterProduit(Produit p);

        void SupprimerProduit(int IdProduit);

        //ICollection<Produit> ListerProduits();

        Produit ModifierProduit(Produit p);

        //Produit AfficherProduit(int IdProduit);

        //ICollection<Produit> RechercherProduitsParNom(string nom);

        ICollection<Produit> RechercherProduitParId(int idProduit);

        /* ******************************* Adresse ******************************* */

        ICollection<AdresseClientModel> ListerAdresseClient();

        /* ******************************* Promotion ******************************* */

        Promotion CreerPromotion(Promotion p);

        void SupprimerPromotion(int PromotionId);

        Promotion ModifierPromotion(Promotion p);

        /* ******************************* Catalogue ******************************* */

        Catalogue AjouterCatalogue(Catalogue c);

        void SupprimerCatalogue(int CatalogueId);

        ICollection<Catalogue> ListerCatalogue();

        //ICollection<ProduitCatalogueModel> ListerProduitCatalogue();

        /* ******************************* Abonnement ******************************* */

        Abonnement CreerAbonnement(Abonnement a);

        void SupprimerAbonnement(int IdAbonnement);

        ICollection<Abonnement> ListerTousAbonnements();
    }
}
