using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AddEmployes.Models;

namespace AddEmployes.Controllers
{
    public class EmployesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Employes
        public ActionResult Index()
        {
            return View(db.Employes.ToList());
        }

        // GET: Employes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employes employes = db.Employes.Find(id);
            if (employes == null)
            {
                return HttpNotFound();
            }
            return View(employes);
        }

        // GET: Employes/Create
        public ActionResult Create()
        {
            ViewBag.GenderEmp = new SelectList(new[] {  "Male", "Female" });
            return View();
        }

        // POST: Employes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameEmploye,Email,City,AgeEmp,GenderEmp")] Employes employes)
        {
            if (ModelState.IsValid)
            {
                ViewBag.GenderEmp = new SelectList(new[] { "Male", "Female" });

                db.Employes.Add(employes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employes);
        }

        // GET: Employes/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.GenderEmp = new SelectList(new[] { "Male", "Female" });

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employes employes = db.Employes.Find(id);
            if (employes == null)
            {
                return HttpNotFound();
            }
            return View(employes);
        }

        // POST: Employes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameEmploye,Email,City,AgeEmp,GenderEmp")] Employes employes)
        {
            if (ModelState.IsValid)
            {
                ViewBag.GenderEmp = new SelectList(new[] { "Male", "Female" });

                db.Entry(employes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employes);
        }

        // GET: Employes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employes employes = db.Employes.Find(id);
            if (employes == null)
            {
                return HttpNotFound();
            }
            return View(employes);
        }

        // POST: Employes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employes employes = db.Employes.Find(id);
            db.Employes.Remove(employes);
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
