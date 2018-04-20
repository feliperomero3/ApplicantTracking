using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApplicantTracking.Data.Identity;
using ApplicantTracking.Data.Repositores;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Web.Controllers
{
    public class ApplicantController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private IApplicantRepository _repository;

        public ApplicantController(IApplicantRepository repository)
        {
            _repository = repository;
        }

        // GET: Applicant
        public ActionResult Index()
        {
            var applicants = _repository.GetApplicants();
            return View(applicants.ToList());
        }

        // GET: Applicant/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: Applicant/Create
        public ActionResult Create()
        {
            ViewBag.DomicilioId = new SelectList(db.Domicilios, "DomicilioId", "Calle");
            return View();
        }

        // POST: Applicant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicantId,ApellidoParterno,ApellidoMaterno,Nombre,FechaNacimiento,DomicilioId,Nacionalidad,Rfc,Curp")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Applicants.Add(applicant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DomicilioId = new SelectList(db.Domicilios, "DomicilioId", "Calle", applicant.DomicilioId);
            return View(applicant);
        }

        // GET: Applicant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            ViewBag.DomicilioId = new SelectList(db.Domicilios, "DomicilioId", "Calle", applicant.DomicilioId);
            return View(applicant);
        }

        // POST: Applicant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicantId,ApellidoParterno,ApellidoMaterno,Nombre,FechaNacimiento,DomicilioId,Nacionalidad,Rfc,Curp")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DomicilioId = new SelectList(db.Domicilios, "DomicilioId", "Calle", applicant.DomicilioId);
            return View(applicant);
        }

        // GET: Applicant/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: Applicant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = db.Applicants.Find(id);
            db.Applicants.Remove(applicant);
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
