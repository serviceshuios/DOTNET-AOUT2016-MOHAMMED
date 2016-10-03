using SiteMarchand_ME.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SiteMarchand_ME.Dao
{
    public class DaoImpl : IDao
    {
        /* ******************************* Compte ******************************* */
        public Utilisateur AfficherCompte(int IdUtilisateur)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.utilisateurs.Find(IdUtilisateur);
            }
        }

        public Utilisateur ConnexionCompte(Utilisateur ut)
        {
            using (var bdd = new ApplicationContext())
            {
                var usr = from u in bdd.utilisateurs
                          where u.Pseudo == ut.Pseudo && u.Password == ut.Password
                          select u;

                return usr.FirstOrDefault();
            }
        }

        public Administrateur CreationCompteAdmin(Administrateur a)
        {
            using (var bdd = new ApplicationContext())
            {
                a.Role = 0;
                bdd.utilisateurs.Add(a);
                bdd.SaveChanges();
                return a;
            }
        }

        public Client CreationCompteClient(Client c)
        {
            using (var bdd = new ApplicationContext())
            {
                c.Role = 1;
                c.NombrePoints = 0;
                c.CompteASupprimer = false;
                c.Actif = true;
                bdd.utilisateurs.Add(c);

                bdd.SaveChanges();
                return c;
            }
        }

        public void SuppressionCompte(int IdUtilisateur)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.utilisateurs.Find(IdUtilisateur);
                bdd.utilisateurs.Remove(res);
                bdd.SaveChanges();
            }
        }

        public ICollection<Utilisateur> ListerComptes()
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.utilisateurs.ToList();
            }
        }

        public Client ModifierCompte(Client c)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(c).State = EntityState.Modified;
                bdd.SaveChanges();
                return c;
            }
        }

        /* **************************** Utilisateur **************************** */
        public Utilisateur ModifierUtilisateur(Utilisateur u)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(u).State = EntityState.Modified;
                bdd.SaveChanges();
                return u;
            }
        }

        public ICollection<Utilisateur> ListerAdministrateur()
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from c in bdd.utilisateurs
                          where c.Role == 0
                          select c;
                return res.ToList();
            }
        }

        public ICollection<Utilisateur> ListerClient()
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from c in bdd.utilisateurs
                          where c.Role == 1
                          select c;

                return res.ToList();
            }
        }

        public Utilisateur RechercherUtilisateurParId(int IdUtilisateur)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.utilisateurs.Find(IdUtilisateur);
            }
        }

        public ICollection<Utilisateur> RechercherUtilisateurParNom(string nom)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from u in bdd.utilisateurs
                          where u.Nom.Contains(nom)
                          select u;
                return res.ToList();
            }
        }
     
        /* ******************************* Commande ******************************* */
        public Commande CreerCommande(Commande c)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.commandes.Add(c);
                bdd.SaveChanges();
                return c;
            }
        }

        public void SupprimerCommande(int IdCommande)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.commandes.Find(IdCommande);
                bdd.commandes.Remove(res);
                bdd.SaveChanges();
            }
        }

        public Commande ModifierCommande(Commande c)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(c).State = EntityState.Modified;
                bdd.SaveChanges();
                return c;
            }
        }

        public ProduitCommande AjouterLigneCommande(ProduitCommande p)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.produitCommandes.Add(p);
                bdd.SaveChanges();
                return p;
            }
        }

        public void SupprimerLigneCommande(int IdProduit, int IdCommande)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.produitCommandes.Find(IdProduit, IdCommande);
                bdd.produitCommandes.Remove(res);
                bdd.SaveChanges();
            }
        }

        public ProduitCommande ModifierLigneCommande(ProduitCommande p)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(p).State = EntityState.Modified;
                bdd.SaveChanges();
                return p;
            }
        }

        public Commande AfficherCommande(int IdCommande)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.commandes.Find(IdCommande);
            }
        }

        public ICollection<Commande> ListerCommandes(int IdUtilisateur)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from c in bdd.commandes
                          where c.UtilisateurId == IdUtilisateur
                          select c;
                return res.ToList();

            }
        }


        /* ******************************* Produit ******************************* */
        public Produit AjouterProduit(Produit p)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.produits.Add(p);
                bdd.SaveChanges();
                return p;
            }
        }

        public void SupprimerProduit(int IdProduit)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.produits.Find(IdProduit);
                bdd.produits.Remove(res);
                bdd.SaveChanges();
            }
        }

        public ICollection<Produit> RechercherProduitsParNom(string nom)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from p in bdd.produits
                          where p.NomProduit.Contains(nom)
                          select p;

                return res.ToList();
            }
        }

        public ICollection<Produit> RechercherProduits(decimal prixMin, decimal prixMax)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from p in bdd.produits
                          where p.Prix >= prixMin && p.Prix <= prixMax
                          select p;

                return res.ToList();
            }
        }

        public ICollection<Produit> RechercherProduitsParCategorie(string Categorie)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from p in bdd.produits
                          where p.Categorie == Categorie
                          select p;
                return res.ToList();
            }
        }

        public Produit ModifierProduit(Produit p)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(p).State = EntityState.Modified;
                bdd.SaveChanges();
                return p;
            }
        }

        public ICollection<Produit> ListerProduits()
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.produits.ToList();
            }
        }

        public Produit AfficherProduit(int IdProduit)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.produits.Find(IdProduit);
            }
        }

        public ICollection<Produit> RechercherProduitParId(int idProduit)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from p in bdd.produits
                          where p.ProduitId == idProduit
                          select p;
                return res.ToList();
            }
        }


        /* ******************************* Catalogue ******************************* */
        public Catalogue AjouterCatalogue(Catalogue c)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.catalogues.Add(c);
                bdd.SaveChanges();
                return c;
            }
        }

        public void SupprimerCatalogue(int IdCatalogue)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.catalogues.Find(IdCatalogue);
                bdd.catalogues.Remove(res);
                bdd.SaveChanges();
            }
        }

        public Catalogue AfficherCatalogue(int IdCatalogue)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.catalogues.Find(IdCatalogue);
            }
        }

        public ICollection<Catalogue> ListerCatalogue()
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.catalogues.ToList();
            }
        }

        public ICollection<ProduitCatalogueModel> ListerProduitCatalogue()
        {
            using (var bdd = new ApplicationContext())
            {
                var req = from p in bdd.produits
                          join c in bdd.catalogues on p.CatalogueId equals c.CatalogueId
                          select new ProduitCatalogueModel
                          {
                              ProduitId = p.ProduitId,
                              NomProduit = p.NomProduit,
                              Prix = p.Prix,
                              Stock = p.Stock,
                              Categorie = p.Categorie,
                              NomCatalogue = c.Nom
                          };
                return req.ToList();
            }
        }

        /* ******************************* Promotion ******************************* */
        public Promotion CreerPromotion(Promotion p)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.promotions.Add(p);
                bdd.SaveChanges();
                return p;
            }
        }

        public void SupprimerPromotion(int IdPromotion)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.promotions.Find(IdPromotion);
                bdd.promotions.Remove(res);
                bdd.SaveChanges();
            }
        }

        public Promotion ModifierPromotion(Promotion p)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(p).State = EntityState.Modified;
                bdd.SaveChanges();
                return p;
            }
        }

        public Promotion AfficherPromotion(int IdPromotion)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.promotions.Find(IdPromotion);
            }
        }

        /* ******************************* Avis ******************************* */
        public AvisClientProduit AjouterAvis(AvisClientProduit com)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.avisClientProduits.Add(com);
                bdd.SaveChanges();
                return com;
            }
        }

        public AvisClientProduit AfficherAvis(int IdUtilisateur, int IdProduit)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from dp in bdd.avisClientProduits
                          where dp.UtilisateurId == IdUtilisateur && dp.ProduitId == IdProduit
                          select dp;

                return res.ToList()[0];
            }
        }

        public void SupprimerAvis(int IdUtilisateur, int IdProduit)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.avisClientProduits.Find(IdUtilisateur, IdProduit);
                bdd.avisClientProduits.Remove(res);
                bdd.SaveChanges();
            }
        }

        public AvisClientProduit ModifierAvis(AvisClientProduit com)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(com).State = EntityState.Modified;
                bdd.SaveChanges();
                return com;
            }
        }

        /* ******************************* Adresse ******************************* */
        public Adresse AjouterAdresse(Adresse a)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.adresses.Add(a);
                bdd.SaveChanges();
                return a;
            }
        }

        public void SupprimerAdresse(int IdAdresse)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.adresses.Find(IdAdresse);
                bdd.adresses.Remove(res);
                bdd.SaveChanges();
            }
        }

        public Adresse AfficherAdresse(int IdAdresse)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.adresses.Find(IdAdresse);
            }
        }

        public Adresse ModifierAdresse(Adresse a)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.Entry(a).State = EntityState.Modified;
                bdd.SaveChanges();
                return a;
            }
        }

        public AdresseClient AjouterAdresseClient(AdresseClient a)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.adresseClients.Add(a);
                bdd.SaveChanges();
                return a;
            }
        }

        public ICollection<Adresse> ListerAdresse(int IdUtilisateur)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from a in bdd.adresses
                          join ac in bdd.adresseClients on a.AdresseId equals ac.AdresseId
                          where ac.UtilisateurId == IdUtilisateur
                          select a;

                return res.ToList();
            }
        }

        public ICollection<AdresseClientModel> ListerAdresseClient()
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from ac in bdd.adresseClients
                          join a in bdd.adresses on ac.AdresseId equals a.AdresseId
                          join u in bdd.utilisateurs on ac.UtilisateurId equals u.UtilisateurId
                          select new AdresseClientModel
                          {
                              Nom = u.Nom,
                              Prenom = u.Prenom,
                              NumeroRue = a.NumeroRue,
                              NomRue = a.NomRue,
                              CodePostal = a.CodePostal,
                              Ville = a.Ville
                          };

                return res.ToList();
            }
        }

        /* ******************************* Abonnement ******************************* */
        public Abonnement AjouterAbonnement(Abonnement a)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.abonnements.Add(a);
                bdd.SaveChanges();
                return a;
            }
        }

        public void SupprimerAbonnement(int IdAbonnement)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.abonnements.Find(IdAbonnement);
                bdd.abonnements.Remove(res);
                bdd.SaveChanges();
            }
        }

        public Abonnement CreerAbonnement(Abonnement a)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.abonnements.Add(a);
                bdd.SaveChanges();
                return a;
            }
        }

        public Abonnement AfficherAbonnement(int IdAbonnement)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.abonnements.Find(IdAbonnement);
            }
        }

        public ICollection<Abonnement> ListerAbonnement(int IdUtilisateur)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = from a in bdd.abonnements
                          join ac in bdd.abonnementClients on a.AbonnementId equals ac.AbonnementId
                          where ac.UtilisateurId == IdUtilisateur
                          select a;

                return res.ToList();
            }
        }

        public AbonnementClient AjouterAbonnementClient(AbonnementClient ac)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.abonnementClients.Add(ac);
                bdd.SaveChanges();
                return ac;
            }
        }

        public ICollection<Abonnement> ListerTousAbonnements()
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.abonnements.ToList();
            }
        }

        public void SupprimerAbonnementClient(int IdAbonnement, int IdUtilisateur)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.abonnementClients.Find(IdAbonnement, IdUtilisateur);
                bdd.abonnementClients.Remove(res);
                bdd.SaveChanges();
            }
        }

        public ICollection<Promotion> ListerPromotions()
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.promotions.ToList();
            }
        }

        /* **************************** Panier **************************** */
        public Panier AjouterPanier(Panier p)
        {
            using (var bdd = new ApplicationContext())
            {
                bdd.paniers.Add(p);
                bdd.SaveChanges();
                return p;
            }
        }

        public void SupprimerPanier(int IdPanier)
        {
            using (var bdd = new ApplicationContext())
            {
                var res = bdd.paniers.Find(IdPanier);
                bdd.paniers.Remove(res);
                bdd.SaveChanges();
            }
        }

        public Panier AfficherPanier(int IdPanier)
        {
            using (var bdd = new ApplicationContext())
            {
                return bdd.paniers.Find(IdPanier);
            }
        }
    }
}