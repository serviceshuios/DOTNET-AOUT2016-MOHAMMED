using System.Collections.Generic;

namespace SiteMarchand_ME.Models
{
    public interface IUtilisateur
    {
        Utilisateur AfficherCompte(int IdUtilisateur);
        ICollection<Produit> ListerProduits();
        ICollection<ProduitCatalogueModel> ListerProduitCatalogue();
        Produit AfficherProduit(int IdProduit);
        ICollection<Produit> RechercherProduitsParNom(string nom);
        Utilisateur ConnexionCompte(Utilisateur ut);
    }
}
