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
        CVGS_Tables db = new CVGS_Tables();
        public ActionResult Index(string search)
        {
            var games = from m in db.Games
                         select m;

            if (!String.IsNullOrEmpty(search))
            {
                games = games.Where(s => s.EnglishName.Contains(search));
            }

            return View(games.ToList());
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
        public ActionResult Signup(Person U)
        {
            if(ModelState.IsValid)
            {
                using (CVGS_Tables db = new CVGS_Tables())
                {
                    U.Id = 10;
                    var check = db.People.FirstOrDefault(s => s.Email == U.Email);
                    if (check == null)
                    {
                        U.ProvinceCode = "ON";
                        U.CountryCode = "CAN";
                        
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
        public ActionResult Login(Person personModel)
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
                    Response.Write("<script language=javascript>alert('You are now logged in')</script>");
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