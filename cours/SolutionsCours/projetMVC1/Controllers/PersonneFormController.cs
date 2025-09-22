using projetMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetMVC1.Controllers
{
    public class PersonneFormController : Controller
    {
        // GET: PersonneForm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPlus()
        {
            DaoPersonne d = new DaoPersonne();
            return View(d);
        }

        [HttpGet]
        public ActionResult GoInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoInsert(Personne p)
        {
            DaoPersonne d = new DaoPersonne();
            d.Insert(p);
            return View(p);
        }

        //PersonneForm/GoUpdate/1
        public ActionResult GoUpdate(int id)
        {
            DaoPersonne d = new DaoPersonne();
            Personne p = d.SelectById(id);
            return View(p);
        }


        [HttpPost]
        public ActionResult DoUpdate(Personne p)
        {
            DaoPersonne d = new DaoPersonne();
            d.Update(p);
            return View();
        }

        public ActionResult Delete(int id)
        {
            string vue;
            DaoPersonne d = new DaoPersonne();
            Personne p = d.SelectById(id);
            if (p != null)
            {
                d.Delete(id);
                vue = "Delete";
            }
            else
            {
                vue = "Error";
                ViewBag.Message = id;
            }
            return View(vue, p);
        }

        [HttpGet]
        public ActionResult GoConnect()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoConnect(Personne p)
        {
            DaoPersonne d = new DaoPersonne();
            Personne personne = d.SelectById(p.Id);

            if (personne != null && personne.Nom == p.Nom)
            {
                ViewBag.Message = "Connexion réussie";
                return View(personne);
            }
            else
            {
                ViewBag.Message = $"Connexion invalide pour Id={p.Id}, Mdp={p.Nom}";
                return View();
            }
        }


    }
}