using SiteMarchand_ME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteMarchand_ME.Controllers
{
    public class AdminController : Controller
    {
        IAdministrateur Iadministrateur = new AdministrateurImpl();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SupprimerCompte(int id)
        {
            Iadministrateur.SuppressionCompte(id);
            // ViewBag.Message = "Le produit a été supprimé";
            return RedirectToAction("ListerClient");
        }

        public ActionResult ListerComptes()
        {
            ICollection<Utilisateur> res = Iadministrateur.ListerComptes();
            ViewBag.Message = "Liste des clients";
            return View(res);
        }

        public ActionResult TrouverUtilisateurParNom()
        {
            ICollection<Utilisateur> res = Iadministrateur.ListerComptes();
            return View(res);
        }

        //[HttpPost]
        //public ActionResult TrouverClientParNom(string nom)
        //{
        //    ICollection<Client> res = Iadministrateur.t(nom);
        //    return View(res);
        //}

        //public ActionResult AjouterClient()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult AjouterClient(Client c)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Iadministrateur.AjouterClient(c);
        //        return RedirectToAction("ListerClient");
        //    }
        //    else
        //    {
        //        return View(c);
        //    }
        //}

        public ActionResult AjouterAdministrateur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterAdministrateur(Administrateur a)
        {
            Iadministrateur.CreationCompteAdmin(a);
            return RedirectToAction("ListerAdministrateur");
        }

        public ActionResult ListerAdministrateur()
        {
            var res = Iadministrateur.ListerComptes();
            return View(res);
        }

        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAdmin(Utilisateur u)
        {
            var user = Iadministrateur.ConnexionCompte(u);
            if (user != null)
            {
                Session["UtilisateurId"] = user.UtilisateurId;
                Session["Role"] = user.Role;
                return RedirectToAction("LoggedInAdmin");
            }
            else
            {
                ModelState.AddModelError("", "Utilisateur ou mot de passe incorrect");
                return View(u);
            }
        }

        public ActionResult LoggedInAdmin()
        {
            var role = (int)(Session["Role"]);
            if ((Session["UtilisateurId"] != null) && (role == 0))
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginAdmin");
            }
        }

        public ActionResult Logout()
        {
            Session["UtilisateurId"] = null;
            Session["Role"] = null;

            return RedirectToAction("LoginAdmin");
        }
    }
}