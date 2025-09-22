using projetMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetMVC1.Controllers
{
    public class PersonneController : Controller
    {
        // GET: Personne
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectAll()
        {
            List<Personne> liste = new DaoPersonne().SelectAll();
            return View(liste);
        }

        //Personne/SelectById/1
        public ActionResult SelectById(string id)
        {
            return View(new DaoPersonne().SelectById(Convert.ToInt32(id)));
        }

        //Personne/Insert/20?nom=dupond&prenom=jean&age=10
        public ActionResult Insert(string id, string nom, string prenom, string age)
        {
            Personne p = new Personne(Convert.ToInt32(id), nom, prenom, Convert.ToInt32(age));
            new DaoPersonne().Insert(p);
            return View();
        }

        //Personne/Update/15?nom=xxx&prenom=yyy&age=25
        public ActionResult Update(string id, string nom, string prenom, string age)
        {
            Personne p = new Personne(Convert.ToInt32(id), nom, prenom, Convert.ToInt32(age));
            new DaoPersonne().Update(p);
            return View();
        }

        //Personne/Delete/20
        public ActionResult Delete(string id)
        {
            new DaoPersonne().Delete(Convert.ToInt32(id));
            return View();
        }


    }
}