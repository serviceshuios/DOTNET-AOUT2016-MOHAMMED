using SiteMarchand_ME.Models;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class CatalogueController : Controller
    {
        IAdministrateur Iadministrateur = new AdministrateurImpl();
        // GET: Catalogue
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjouterCatalogue()
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
        public ActionResult AjouterCatalogue(Catalogue c)
        {
            Iadministrateur.AjouterCatalogue(c);
            return RedirectToAction("LoginAdmin","Administrateur");
        }
    }
}