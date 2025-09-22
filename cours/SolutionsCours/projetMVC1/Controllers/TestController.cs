using projetMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetMVC1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test1()
        {
            Data d = new Data("coucou");
            return View(d);
        }

        public ActionResult Test2()
        {
            return View("Test1", new Data("coucou v2"));
        }

        //Test/Test3/toto
        public ActionResult Test3(string id)
        {
            Data d = new Data(id);

            return View("Test1", d);
        }

        //Test/Test4/toto?nom=dupond&prenom=jean&age=10
        public ActionResult Test4(string id, string nom, string prenom, string age)
        {
            string str = id + "  " + nom + "  " + prenom + "  " + age;
            Data d = new Data(str);

            return View("Test1", d);
        }

        public ActionResult Test5()
        {
            return View(new Client("toto", "titi"));
        }

        //Test/Test6/toto ou Test/Test6
        public ActionResult Test6(int? id)
        {
            DataInt d = new DataInt(id);
            return View(d);
        }

        public ActionResult Test7()
        {
            List<Client> liste = new List<Client>();
            liste.Add(new Client("aa", "bb"));
            liste.Add(new Client("cc", "dd"));
            return View(liste);
        }

        public ActionResult Test8()
        {
            return View();
        }


        //Test/Test9/10/zara  //Test/Test9
        public ActionResult Test9(int? id, string categorie)
        {
            ViewBag.Message = $"Produit n°{id}, Catégorie : {categorie}";
            return View();
        }

        //Test/Test10/10/zara/10
        public ActionResult Test10(int id, string marque, int prix)
        {
            ViewBag.Message = $"Produit n°{id}, marque : {marque}, prix : {prix}";
            return View();
        }

        public ActionResult Test11()
        {
            return View();
        }

        public ActionResult Test12()
        {
            if (HttpContext.Application["test"] == null)
                HttpContext.Application["test"] = "ok";

            return View();
        }

        public ActionResult Test13()
        {
            return View();
        }










    }
}