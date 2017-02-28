using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using StudentsCol.Models;
using System.Web.Security;

namespace StudentsCol.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string username = form["username"].ToString();
            string password = form["password"].ToString();

            

            if (username == "Tareq" && password == "123")
            {
                //Create seession/ token for loged in user
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToAction("Index", "Dashboard");
                //MessageBox.Show("Test");
            }

            if (username != "" || password != "")
            {
                TempData["Message"] = "Username or password is wrong";
            }
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}
