using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BehafarinClinic.Models;

namespace BehafarinClinic.Controllers
{
    public class InfirmaryPersonnelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: InfirmaryPersonnels
        public ActionResult Index()
        {
            return View(db.InfirmaryPersonnels.ToList());
        }

        // GET: InfirmaryPersonnels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfirmaryPersonnel infirmaryPersonnel = db.InfirmaryPersonnels.Find(id);
            if (infirmaryPersonnel == null)
            {
                return HttpNotFound();
            }
            return View(infirmaryPersonnel);
        }

        // GET: InfirmaryPersonnels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfirmaryPersonnels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InfirmaryPersonnelId,PersonnelId,FirstName,LastName")] InfirmaryPersonnel infirmaryPersonnel)
        {
            if (ModelState.IsValid)
            {
                db.InfirmaryPersonnels.Add(infirmaryPersonnel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infirmaryPersonnel);
        }

        // GET: InfirmaryPersonnels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfirmaryPersonnel infirmaryPersonnel = db.InfirmaryPersonnels.Find(id);
            if (infirmaryPersonnel == null)
            {
                return HttpNotFound();
            }
            return View(infirmaryPersonnel);
        }

        // POST: InfirmaryPersonnels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InfirmaryPersonnelId,PersonnelId,FirstName,LastName")] InfirmaryPersonnel infirmaryPersonnel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infirmaryPersonnel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infirmaryPersonnel);
        }

        // GET: InfirmaryPersonnels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfirmaryPersonnel infirmaryPersonnel = db.InfirmaryPersonnels.Find(id);
            if (infirmaryPersonnel == null)
            {
                return HttpNotFound();
            }
            return View(infirmaryPersonnel);
        }

        // POST: InfirmaryPersonnels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InfirmaryPersonnel infirmaryPersonnel = db.InfirmaryPersonnels.Find(id);
            db.InfirmaryPersonnels.Remove(infirmaryPersonnel);
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
