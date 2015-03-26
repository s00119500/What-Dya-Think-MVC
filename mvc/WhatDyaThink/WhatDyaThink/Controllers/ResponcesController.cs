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

namespace WhatDyaThink.Controllers
{
    public class ResponcesController : Controller
    {
        private SurveyContext db = new SurveyContext();

        // GET: Responces
        public ActionResult Index()
        {
            var responces = db.Responces.Include(r => r.Question);
            return View(responces.ToList());
        }

        // GET: Responces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responces responces = db.Responces.Find(id);
            if (responces == null)
            {
                return HttpNotFound();
            }
            return View(responces);
        }

        // GET: Responces/Create
        public ActionResult Create()
        {
            ViewBag.questionID = new SelectList(db.Question, "questionID", "questionText");
            return View();
        }

        // POST: Responces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "responceID,questionID,responceType,responceText,responceCSS,responceValue")] Responces responces)
        {
            if (ModelState.IsValid)
            {
                db.Responces.Add(responces);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.questionID = new SelectList(db.Question, "questionID", "questionText", responces.questionID);
            return View(responces);
        }

        // GET: Responces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responces responces = db.Responces.Find(id);
            if (responces == null)
            {
                return HttpNotFound();
            }
            ViewBag.questionID = new SelectList(db.Question, "questionID", "questionText", responces.questionID);
            return View(responces);
        }

        // POST: Responces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "responceID,questionID,responceType,responceText,responceCSS,responceValue")] Responces responces)
        {
            if (ModelState.IsValid)
            {
                db.Entry(responces).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.questionID = new SelectList(db.Question, "questionID", "questionText", responces.questionID);
            return View(responces);
        }

        // GET: Responces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responces responces = db.Responces.Find(id);
            if (responces == null)
            {
                return HttpNotFound();
            }
            return View(responces);
        }

        // POST: Responces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Responces responces = db.Responces.Find(id);
            db.Responces.Remove(responces);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
