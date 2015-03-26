using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class UserAccountController : Controller
    {
        // GET: UserAccount
        public ActionResult Index()
        {
            /// not used
            return View();
        }

        /// user wants to log on 
        public ActionResult Login() { return View(); }

        /// user wants to register
        public ActionResult Register() { return View(); }
    }
}