using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;
using System.Security.Cryptography;
using System.Text;

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
            ViewBag.Message = "Log in page";

            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Person U)
        {
            if(ModelState.IsValid)
            {
                using (CVGS_Tables db = new CVGS_Tables())
                {
                    var check = db.People.FirstOrDefault(s => s.Email == U.Email);
                    if (check == null)
                    {
                        U.Password = GetMD5(U.Password);
                        db.Configuration.ValidateOnSaveEnabled = false;
                        db.People.Add(U);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.error = "Email already exists";
                        return View();
                    }
                }
            }
            return View();
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
        public ActionResult Account()
        {
            ViewBag.Message = "User's profile page";
            if (Session["userId"] == null)
            {
                TempData["Message"] = "Login to view your account info";
                Response.Redirect("~/Home/Login");
            }

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Page with the list of events";

            return View();
        }

        public ActionResult AdministrationPortal()
        {
            ViewBag.Message = "Administration Portal";

            return View();
        }

        [HttpPost]
        public ActionResult Authorize(Person personModel)
        {
            using (CVGS_Tables db = new CVGS_Tables())
            {
                var userDetails = db.People.ToList().Where(x => (x.UserName == personModel.UserName && 
                x.Password == personModel.Password)).FirstOrDefault();
                if (userDetails == null)
                {
                    personModel.LoginErrorMessage = "Wrong Username or Password";
                    return View("Login", personModel);
                }
                else
                {
                    Session["userId"] = userDetails.Id;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}