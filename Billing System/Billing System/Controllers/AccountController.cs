using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Billing_System;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;


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
               
            using (VertexEntities myEntity = new VertexEntities())
            {
                var user = myEntity.Ver_Users.Where(a => a.Username.Equals(username) && a.Password.Equals(password)).FirstOrDefault();
                if (user != null)
                {
                    //Create seession/ token for loged in user
                    FormsAuthentication.SetAuthCookie(username, false);
                    return RedirectToAction("Index", "Dashboard");
                    //MessageBox.Show("Test");          
                }
                if(username== "" && password=="")
                {
                    TempData["Message"] = null;               
                }
                else
                {
                    TempData["Message"] = "Username or password is wrong";
                }       
            }         
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {          
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login");
        }

    }
}
