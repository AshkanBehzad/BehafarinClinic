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
    public class InfirmaryReceptionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: InfirmaryReceptions
        public ActionResult Index()
        {
            var infirmaryReceptions = db.InfirmaryReceptions.Include(i => i.ReceptionPersonnel);
            return View(infirmaryReceptions.ToList());
        }
        // GET: Unpaid InfirmaryReceptions
        public ActionResult Unpaid()
        {
            var infirmaryReceptions = db.InfirmaryReceptions.Include(i => i.ReceptionPersonnel).Where(ir=> ir.IsPaid==false);
            return View(infirmaryReceptions.ToList());
        }
        // GET: Unfinished InfirmaryReceptions
        public ActionResult Unfinished()
        {
            var infirmaryReceptions = db.InfirmaryReceptions.Include(i => i.ReceptionPersonnel).Where(ir => ir.IsFinished == false);
            return View(infirmaryReceptions.ToList());
        }
        // GET: InfirmaryReceptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfirmaryReception infirmaryReception = db.InfirmaryReceptions.Find(id);
            if (infirmaryReception == null)
            {
                return HttpNotFound();
            }
            return View(infirmaryReception);
        }

        // GET: InfirmaryReceptions/Create
        public ActionResult Create()
        {
            ViewBag.PersonnelId = new SelectList(db.Personnels, "PersonnelId", "LastName");
            ViewBag.OrganizationId = new SelectList(db.InsuranceOrganizations, "OrganizationId", "OrganizationId");
            InfirmaryReception ir = new InfirmaryReception { DateTime = DateTime.Now };
            return View(ir);
        }

        // POST: InfirmaryReceptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InfirmaryReceptionId,OrganizationId,PersonnelId,DateTime,PatientName,PayableAmount,Descriptions")] InfirmaryReception infirmaryReception)
        {
            if (ModelState.IsValid)
            {
                db.InfirmaryReceptions.Add(infirmaryReception);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonnelId = new SelectList(db.Personnels, "PersonnelId", "LastName", infirmaryReception.PersonnelId);
            return View(infirmaryReception);
        }

        // GET: InfirmaryReceptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfirmaryReception infirmaryReception = db.InfirmaryReceptions.Find(id);
            if (infirmaryReception == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonnelId = new SelectList(db.Personnels, "PersonnelId", "LastName", infirmaryReception.PersonnelId);
            return View(infirmaryReception);
        }

        // POST: InfirmaryReceptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InfirmaryReceptionId,OrganizationId,PersonnelId,DateTime,PatientName,PayableAmount,Descriptions")] InfirmaryReception infirmaryReception)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infirmaryReception).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonnelId = new SelectList(db.Personnels, "PersonnelId", "LastName", infirmaryReception.PersonnelId);
            return View(infirmaryReception);
        }

        // GET: InfirmaryReceptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfirmaryReception infirmaryReception = db.InfirmaryReceptions.Find(id);
            if (infirmaryReception == null)
            {
                return HttpNotFound();
            }
            return View(infirmaryReception);
        }

        // POST: InfirmaryReceptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InfirmaryReception infirmaryReception = db.InfirmaryReceptions.Find(id);
            db.InfirmaryReceptions.Remove(infirmaryReception);
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
