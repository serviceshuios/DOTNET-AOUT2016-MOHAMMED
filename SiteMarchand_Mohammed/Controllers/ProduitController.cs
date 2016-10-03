using SiteMarchand_ME.Models;
using System.Web.Mvc;

namespace SiteMarchand_ME.Controllers
{
    public class ProduitController : Controller
    {
        IAdministrateur Iadministrateur = new AdministrateurImpl();
        // GET: Personne
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjouterProduit()
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                ViewBag.CatalogueId = new SelectList(Iadministrateur.ListerCatalogue(), "CatalogueId", "Nom");
                return View();
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult AjouterProduit(Produit p)
        {
            Iadministrateur.AjouterProduit(p);
            ViewBag.CatalogueId = new SelectList(Iadministrateur.ListerCatalogue(), "CatalogueId", "Nom");
            return RedirectToAction("ListerProduitsAdmin");
        }

        public ActionResult ListerProduitsAdmin()
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                var res = Iadministrateur.ListerProduitCatalogue();
                return View(res);
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }

        public ActionResult ModifierProduit(int id)
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                Produit p = Iadministrateur.AfficherProduit(id);
                ViewBag.CatalogueId = new SelectList(Iadministrateur.ListerCatalogue(), "CatalogueId", "Nom", p.CatalogueId);
                return View(p);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult ModifierProduit(Produit p)
        {
            var res = Iadministrateur.ModifierProduit(p);

            return RedirectToAction("ListerProduitsAdmin");
        }

        public ActionResult SupprimerProduit(int id)
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                Iadministrateur.SupprimerProduit(id);
                return RedirectToAction("ListerProduitsAdmin");
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }

        public ActionResult RechercherProduitParNom()
        {
            var role = (int)(Session["role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                var res = Iadministrateur.ListerProduits();
                return View(res);
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult RechercherProduitParNom(string nom)
        {
            var res = Iadministrateur.RechercherProduitsParNom(nom);
            return View(res);
        }

        public ActionResult RechercherProduitParId()
        {
            var role = (int)(Session["role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                var res = Iadministrateur.ListerProduits();
                return View(res);
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult RechercherProduitParId(int id)
        {
            var res = Iadministrateur.RechercherProduitParId(id);
            return View(res);
        }


        public ActionResult AfficherProduit(int id)
        {
            var role = (int)(Session["role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                var res = Iadministrateur.AfficherProduit(id);
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }
    }
}