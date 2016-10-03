using SiteMarchand_ME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteMarchand_ME.Controllers
{
    public class ClientController : Controller
    {
        IClient iclient = new ClientImpl();
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inscription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inscription(Client c)
        {
            iclient.CreationCompteClient(c);
            return RedirectToAction("Connexion");
        }

        public ActionResult Connexion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Connexion(Utilisateur ut)
        {
            var monUser = iclient.ConnexionCompte(ut);

            if (monUser != null)
            {
                Session["ClientId"] = monUser.UtilisateurId;
                Session["Role"] = monUser.Role;
                Session["Nom"] = monUser.Nom;
                Session["Prenom"] = monUser.Prenom;
                return RedirectToAction("LoggedIn");
            }
            else
            {
                ModelState.AddModelError("", "Utilisateur ou mot de passe incorrect");
                return View();
            }
        }

        public ActionResult LoggedIn()
        {
            var role = (int)(Session["Role"]);
            if ((Session["ClientId"] != null) && (role == 1))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Connexion");
            }
        }

        public ActionResult Logout(Client c)
        {
            Session["ClientId"] = null;
            Session["Role"] = null;
            Session["Nom"] = null;
            Session["Prenom"] = null;
            return RedirectToAction("Connexion");
        }

        public ActionResult ModifierCompte()
        {
            var role = (int)(Session["Role"]);
            if ((Session["ClientId"] != null) && (role == 1))
            {
                var res = iclient.AfficherCompte(Convert.ToInt32(Session["ClientId"]));
                return View(res);
            }
            else
            {
                return RedirectToAction("Connexion");
            }
        }

        [HttpPost]
        public ActionResult ModifierCompte(Client c)
        {
            iclient.ModifierCompte(c);
            return RedirectToAction("LoggedIn");
        }

        public ActionResult AjouterAdresse()
        {
            var role = (int)(Session["Role"]);
            if ((Session["ClientId"] != null) && (role == 1))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Connexion");
            }
        }

        [HttpPost]
        public ActionResult AjouterAdresse(Adresse a)
        {
            var adresse = iclient.AjouterAdresse(a);

            return RedirectToAction("LoggedIn");
        }

        public ActionResult SupprimerAdresse(int AdresseId)
        {
            var role = (int)(Session["Role"]);
            if ((Session["ClientId"] != null) && (role == 1))
            {
                iclient.SupprimerAdresse(AdresseId);
                return RedirectToAction("AfficherAdresses");
            }
            else
            {
                return RedirectToAction("Connexion");
            }
        }

        public ActionResult AfficherAdresses()
        {
            var role = (int)(Session["Role"]);
            if ((Session["ClientId"] != null) && (role == 1))
            {
                var clientid = (int)(Session["ClientId"]);
                iclient.ListerAdresse(clientid);
                return View();
            }
            else
            {
                return RedirectToAction("Connexion");
            }
        }
    }
}