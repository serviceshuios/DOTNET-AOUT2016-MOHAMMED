using SiteMarchand_ME.Models;
using System.Web.Mvc;

namespace SiteMarchand_ME.Controllers
{
    public class AbonnementController : Controller
    {
        IAdministrateur Iadministrateur = new AdministrateurImpl();
        // GET: Abonnement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjouterAbonnement()
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult AjouterAbonnement(Abonnement a)
        {
            Iadministrateur.CreerAbonnement(a);
            return View("ListerTousAbonnement");
        }

        public ActionResult ListerTousAbonnement()
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                var res = Iadministrateur.ListerTousAbonnements();
                return View(res);
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }

        public ActionResult supprimerAbonnement(int AbonnementId)
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                Iadministrateur.SupprimerAbonnement(AbonnementId);
                return RedirectToAction("ListerTousAbonnement");
            }
            else
            {
                return RedirectToAction("LoginAdmin", "Administrateur");
            }
        }
    }
}