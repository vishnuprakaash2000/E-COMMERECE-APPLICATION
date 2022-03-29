using OnlineShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        onlineshopping db = new onlineshopping();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login Ulogin)
        {
            onlineshopping db = new onlineshopping();


            if (db.Logins.Any(x => x.Username != Ulogin.Username && x.Password != Ulogin.Password))
            {
                Loginpage loginpage = new Loginpage();
                loginpage.Username = Ulogin.Username;
                loginpage.Password = Ulogin.Password;
                db.Loginpages.Add(loginpage);
                db.SaveChanges();
                db.Logins.Add(Ulogin);
                db.SaveChanges();
                Session["Username"] = Ulogin.Username.ToString();
                Session["Useremail"] = Ulogin.Email.ToString();
                Session["Userphonenumber"] = Ulogin.PhoneNumber.ToString();
               
                Session["Userpassword"] = Ulogin.Password.ToString();
                return View("UserLogin");

            }
            else
            {

                return View();
            }
        }
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(Loginpage login)
        {
            if (db.Loginpages.Any(x => x.Username == login.Username && x.Password == login.Password))
            {
                Session["Id"] = login.UserId;
                return RedirectToAction("Index", "Payment");

            }
            else
            {
                ModelState.AddModelError("", "Please Check your Name and Password or SignUp and login");
                return View();
            }
        }
        /*public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            Samples db = new Samples();
            if (db.Admins.Any(x => x.Adminname == admin.Adminname && x.Adminpassword == admin.Adminpassword))
            {
                Session["adminId"] = admin.Adminid;
                return RedirectToAction("Index", "Admin");
            }
            else
            {

                return View();

            }

        }*/
        public ActionResult BuyNow()
        {
            return RedirectToAction("UserLogin", "Home");
        }


    }
}