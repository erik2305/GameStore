using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Log in page.";

            return View();
        }

        public ActionResult Signup()
        {
            ViewBag.Message = "Sign up page.";

            return View();
        }

        public ActionResult Account()
        {
            ViewBag.Message = "User's profile page.";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Page with the list of events";

            return View();
        }
    }
}