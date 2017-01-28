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
    public class ServiceItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ServiceItems
        public ActionResult Index()
        {
            var serviceItems = db.ServiceItems.Include(s => s.InfirmaryPersonnel).Include(s => s.InfirmaryReception).Include(s => s.Service);
            return View(serviceItems.ToList());
        }

        // GET: ServiceItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceItem serviceItem = db.ServiceItems.Find(id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }
            return View(serviceItem);
        }

        // GET: ServiceItems/Create
        public ActionResult Create()
        {
            ViewBag.InfirmaryPersonnelId = new SelectList(db.InfirmaryPersonnels, "InfirmaryPersonnelId", "Name");
            ViewBag.InfirmaryReceptionId = new SelectList(db.InfirmaryReceptions, "InfirmaryReceptionId", "PatientName");
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "SeviceTitle");
            return View();
        }

        // POST: ServiceItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceItemId,InfirmaryReceptionId,InfirmaryPersonnelId,ServiceId,Cost,Description")] ServiceItem serviceItem)
        {
            if (ModelState.IsValid)
            {
                db.ServiceItems.Add(serviceItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InfirmaryPersonnelId = new SelectList(db.InfirmaryPersonnels, "InfirmaryPersonnelId", "PersonnelCode", serviceItem.InfirmaryPersonnelId);
            ViewBag.InfirmaryReceptionId = new SelectList(db.InfirmaryReceptions, "InfirmaryReceptionId", "PatientName", serviceItem.InfirmaryReceptionId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "SeviceTitle", serviceItem.ServiceId);
            return View(serviceItem);
        }

        // GET: ServiceItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceItem serviceItem = db.ServiceItems.Find(id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.InfirmaryPersonnelId = new SelectList(db.InfirmaryPersonnels, "InfirmaryPersonnelId", "PersonnelCode", serviceItem.InfirmaryPersonnelId);
            ViewBag.InfirmaryReceptionId = new SelectList(db.InfirmaryReceptions, "InfirmaryReceptionId", "PatientName", serviceItem.InfirmaryReceptionId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "SeviceTitle", serviceItem.ServiceId);
            return View(serviceItem);
        }

        // POST: ServiceItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceItemId,InfirmaryReceptionId,InfirmaryPersonnelId,ServiceId,Cost,Description")] ServiceItem serviceItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InfirmaryPersonnelId = new SelectList(db.InfirmaryPersonnels, "InfirmaryPersonnelId", "PersonnelCode", serviceItem.InfirmaryPersonnelId);
            ViewBag.InfirmaryReceptionId = new SelectList(db.InfirmaryReceptions, "InfirmaryReceptionId", "PatientName", serviceItem.InfirmaryReceptionId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "SeviceTitle", serviceItem.ServiceId);
            return View(serviceItem);
        }

        // GET: ServiceItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceItem serviceItem = db.ServiceItems.Find(id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }
            return View(serviceItem);
        }

        // POST: ServiceItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceItem serviceItem = db.ServiceItems.Find(id);
            db.ServiceItems.Remove(serviceItem);
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
