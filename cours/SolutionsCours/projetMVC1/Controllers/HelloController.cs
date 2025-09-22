using projetMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetMVC1.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test1()
        {
            return View();
        }

        public ActionResult Test2()
        {
            ViewBag.message = "Coucou";
            return View();
        }

        public ActionResult Test3()
        {
            return RedirectToAction("Test2");
        }
        public ActionResult Test4()
        {
            return View("Test2");
        }

        public ActionResult Test5()
        {
            Traitement t = new Traitement();
            return View(t);
        }
    }
}