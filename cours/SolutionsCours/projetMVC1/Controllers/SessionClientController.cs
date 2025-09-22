using projetMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetMVC1.Controllers
{
    public class SessionClientController : Controller
    {
        // GET: SessionClient
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Page1()
        {
            if (Session["client"] == null)
                Session["client"] = new Client("dupond", "titi");
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