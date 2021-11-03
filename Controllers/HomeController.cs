using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        //SqlConnection con = new SqlConnection();
        //SqlCommand com = new SqlCommand();
        //SqlDataReader dr;
        public ActionResult Index()
        {
            return View();
        }
        //void connectionString()
        //{
        //    con.ConnectionString = "data source=[DESKTOP-1SPI0CK\\SQLEXPRESS]; database=CVGS; integrated security=SSPI;";
        //}
      
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Signup(UserRegistration U)
        {
            if (ModelState.IsValid)
            {
                using (CVGSEntities4 cv = new CVGSEntities4())
                {
                    cv.UserRegistrations.Add(U);
                    cv.SaveChanges();
                    ModelState.Clear();
                    U = null;
                    ViewBag.Message = "Successfully Registration Done";
                }
            }
            return View(U);
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserRegistration u)
        {
            if (ModelState.IsValid)
            {
                using(CVGSEntities4 cv=new CVGSEntities4())
                {
                    var v = cv.UserRegistrations.Where(a => a.UserName.Equals(u.UserName) && a.Password.Equals(u.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.UserID.ToString();
                        Session["LogedUserFullName"] = v.FirstName.ToString() + "" + v.LastName.ToString();
                        return RedirectToAction("Events");
                    }
                }
            }
            return View(u);

        }
        //public ActionResult AfterLogin()
        //{
        //    if (Session["LogedUserID"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
           
        //}

        //public RedirectResult Signup()
        //{
        //    return Redirect("/Views/Home/Signup.aspx");
        //}


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

        public ActionResult AdministrationPortal()
        {
            ViewBag.Message = "Administration Portal";

            return View();
        }
    }
}