using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WhatDyaThink.DAL;
using WhatDyaThink.Models;
using System.Web.Security;
using System.Data.Entity.Validation;


namespace WhatDyaThink.Controllers
{
    public class RegistrationsController : Controller
    {
        private SurveyContext db = new SurveyContext();

        // GET: Registrations
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Models.Registration userr)
        {
            //if (ModelState.IsValid)
            //{
            if (IsValid(userr.Email, userr.Password))
            {
                FormsAuthentication.SetAuthCookie(userr.Email, false);
                Session["userName"] = userr.Email.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Login details are wrong.");
            }
            return View(userr);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.Registration user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new SurveyContext())
                    {
                        //var crypto = new SimpleCrypto.PBKDF2();
                        //var encrypPass = crypto.Compute(user.Password);
                        //var newUser = db.Registrations.Create();
                        var newUser = db.Registration.Create();
                        newUser.Email = user.Email;
                        newUser.Password = user.Password;
                        //newUser.PasswordSalt = crypto.Salt;
                        newUser.FirstName = user.FirstName;
                        newUser.LastName = user.LastName;
                        newUser.UserType = "User";
                        newUser.CreatedDate = DateTime.Now;
                        newUser.IsActive = true;
                        //newUser.IPAddress = "642 White Hague Avenue";
                        db.Registration.Add(newUser);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Data is not correct");
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["userName"] = null;
            return RedirectToAction("LogIn", "Registrations");
        }

        private bool IsValid(string email, string password)
        {
            var crypto = password; //= new SimpleCrypto.PBKDF2();
            bool IsValid = false;

            using (var db = new SurveyContext())
            {
                var user = db.Registration.FirstOrDefault(u => u.Email == email);
                if (user != null)
                {
                    if (user.Password == crypto)
                    {
                        IsValid = true;
                    }
                }
            }
            return IsValid;
        }
    }
}
