using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetMVC1.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            if (Session["nom"] == null) Session["nom"] = "Desbois";
            if (Session["prenom"] == null) Session["prenom"] = "Esther";
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }

        public ActionResult Page3()
        {
            return View();
        }
    }
}