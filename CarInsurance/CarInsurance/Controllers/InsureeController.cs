using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Home/
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        //GET: Insuree/Quote
        public ActionResult Quote()
        {
            return View();
        }
        
        

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            
            DateTime now = DateTime.Today;
            decimal quote = 50.00m;
            int age = now.Year - insuree.DateOfBirth.Year;
            decimal ageAdjust = 0;

            if (age <= 18)
            {
                ageAdjust = +100;

            }
            else if (age >= 19 && age <= 25)
            {
                ageAdjust = +50;
            }
            else
            {
                ageAdjust = +25;
            }

            decimal vehicleAdjustment = 0;
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                vehicleAdjustment += 25;
            }
            else if (insuree.CarMake == "Porsche")
            {
                vehicleAdjustment += 25;
            }
            else if (insuree.CarModel == "911 Carrera")
            {
                vehicleAdjustment += 25;
            }

            decimal totalQuote = quote + ageAdjust + vehicleAdjustment;
            decimal oopsieAdjustment = 0;
            if (insuree.SpeedingTickets > 0)
            {
                oopsieAdjustment = oopsieAdjustment + (insuree.SpeedingTickets) * 10;
            }
            if (insuree.DUI == true)
            {
                oopsieAdjustment = oopsieAdjustment + (totalQuote * .25m);
            }
            if (insuree.CoverageType == true)
            {
                oopsieAdjustment = oopsieAdjustment + (totalQuote * .5m);
            }

            decimal finalQuote = totalQuote + oopsieAdjustment;

            


            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }


        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
