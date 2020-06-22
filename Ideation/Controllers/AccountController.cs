using Ideation.Models;
using Ideation.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Ideation.Controllers
{
    public class AccountController : Controller
    {

        private DataContext db = new DataContext();

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Username,Password")] UserLogin userLogin)
        {
            var user = db.Users.FirstOrDefault(x => x.Username == userLogin.Username && x.Password == userLogin.Password);

            if(user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return RedirectToAction("Index", "Meetings");
            }
            else
            {
                ViewBag.LoginError = "Wrong Username or Password.";
            }
            return View();
        }
    }
}