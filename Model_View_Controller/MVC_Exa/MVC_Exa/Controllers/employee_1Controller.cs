using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Exa.Models;

namespace MVC_Exa.Controllers
{
    public class employee_1Controller : Controller
    {
        private mydbEntities db = new mydbEntities();

        // GET: employee_1
        public ActionResult Index()
        {
            return View(db.employee_1.ToList());
        }

        // GET: employee_1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employee_1 employee_1 = db.employee_1.Find(id);
            if (employee_1 == null)
            {
                return HttpNotFound();
            }
            return View(employee_1);
        }

        // GET: employee_1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: employee_1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,firstname,lastname,Salary,city")] employee_1 employee_1)
        {
            if (ModelState.IsValid)
            {
                db.employee_1.Add(employee_1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee_1);
        }

        // GET: employee_1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employee_1 employee_1 = db.employee_1.Find(id);
            if (employee_1 == null)
            {
                return HttpNotFound();
            }
            return View(employee_1);
        }

        // POST: employee_1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,firstname,lastname,Salary,city")] employee_1 employee_1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee_1);
        }

        // GET: employee_1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employee_1 employee_1 = db.employee_1.Find(id);
            if (employee_1 == null)
            {
                return HttpNotFound();
            }
            return View(employee_1);
        }

        // POST: employee_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            employee_1 employee_1 = db.employee_1.Find(id);
            db.employee_1.Remove(employee_1);
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
