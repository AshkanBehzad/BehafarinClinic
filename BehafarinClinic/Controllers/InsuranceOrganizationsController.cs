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
    public class InsuranceOrganizationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: InsuranceOrganizations
        public ActionResult Index()
        {
            return View(db.InsuranceOrganizations.ToList());
        }

        // GET: InsuranceOrganizations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceOrganization insuranceOrganization = db.InsuranceOrganizations.Find(id);
            if (insuranceOrganization == null)
            {
                return HttpNotFound();
            }
            return View(insuranceOrganization);
        }

        // GET: InsuranceOrganizations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceOrganizations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InsuranceOrganizationId,OrganizationName,OrganizationCode,Rate")] InsuranceOrganization insuranceOrganization)
        {
            if (ModelState.IsValid)
            {
                db.InsuranceOrganizations.Add(insuranceOrganization);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuranceOrganization);
        }

        // GET: InsuranceOrganizations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceOrganization insuranceOrganization = db.InsuranceOrganizations.Find(id);
            if (insuranceOrganization == null)
            {
                return HttpNotFound();
            }
            return View(insuranceOrganization);
        }

        // POST: InsuranceOrganizations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InsuranceOrganizationId,OrganizationName,OrganizationCode,Rate")] InsuranceOrganization insuranceOrganization)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuranceOrganization).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuranceOrganization);
        }

        // GET: InsuranceOrganizations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceOrganization insuranceOrganization = db.InsuranceOrganizations.Find(id);
            if (insuranceOrganization == null)
            {
                return HttpNotFound();
            }
            return View(insuranceOrganization);
        }

        // POST: InsuranceOrganizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InsuranceOrganization insuranceOrganization = db.InsuranceOrganizations.Find(id);
            db.InsuranceOrganizations.Remove(insuranceOrganization);
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
