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
    public class ConsumableGoodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ConsumableGoods
        public ActionResult Index()
        {
            return View(db.ConsumableGoods.ToList());
        }

        // GET: ConsumableGoods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsumableGoods consumableGoods = db.ConsumableGoods.Find(id);
            if (consumableGoods == null)
            {
                return HttpNotFound();
            }
            return View(consumableGoods);
        }

        // GET: ConsumableGoods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsumableGoods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConsumableGoodsId,Name,VendorOrProvider,Price,AvailableQuantity,PurchaseDate,Descriptions")] ConsumableGoods consumableGoods)
        {
            if (ModelState.IsValid)
            {
                db.ConsumableGoods.Add(consumableGoods);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consumableGoods);
        }

        // GET: ConsumableGoods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsumableGoods consumableGoods = db.ConsumableGoods.Find(id);
            if (consumableGoods == null)
            {
                return HttpNotFound();
            }
            return View(consumableGoods);
        }

        // POST: ConsumableGoods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConsumableGoodsId,Name,VendorOrProvider,Price,AvailableQuantity,PurchaseDate,Descriptions")] ConsumableGoods consumableGoods)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consumableGoods).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consumableGoods);
        }

        // GET: ConsumableGoods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsumableGoods consumableGoods = db.ConsumableGoods.Find(id);
            if (consumableGoods == null)
            {
                return HttpNotFound();
            }
            return View(consumableGoods);
        }

        // POST: ConsumableGoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConsumableGoods consumableGoods = db.ConsumableGoods.Find(id);
            db.ConsumableGoods.Remove(consumableGoods);
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
