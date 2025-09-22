using projetMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetMVC1.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult Page2(Client c)
        {
            return View(c);
        }

        public ActionResult Page3()
        {
            return View();
        }

        public ActionResult Page4(string nom, string prenom)
        {
            ViewBag.message = nom + "  " + prenom;
            return View();
        }

        public ActionResult Page5()
        {
            return View();
        }

        public ActionResult Page6(string x)
        {
            return View(new Data(x));
        }

        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test(Client c)
        {
            return View(c);
        }
    }
}