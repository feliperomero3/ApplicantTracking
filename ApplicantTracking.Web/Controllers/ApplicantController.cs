using System.Linq;
using System.Net;
using System.Web.Mvc;
using ApplicantTracking.Data.Repositories;
using ApplicantTracking.Domain.Models;

namespace ApplicantTracking.Web.Controllers
{
    public class ApplicantController : Controller
    {
        private IApplicantRepository _repository;

        public ApplicantController(IApplicantRepository repository)
        {
            _repository = repository;
        }

        // GET: Applicant
        public ActionResult Index()
        {
            var applicants = _repository.GetApplicants().ToList();
            return View(applicants);
        }

        // GET: Applicant/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = _repository.GetApplicant(id.Value);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: Applicant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applicant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicantId,ApellidoParterno,ApellidoMaterno,Nombre,FechaNacimiento,Nacionalidad,Rfc,Curp")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                _repository.AddApplicant(applicant);
                return RedirectToAction("Index");
            }

            return View(applicant);
        }

        // GET: Applicant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = _repository.GetApplicant(id.Value);
            if (applicant == null)
            {
                return HttpNotFound();
            }
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
                _repository.UpdateApplicant(applicant);
                return RedirectToAction("Index");
            }
            return View(applicant);
        }

        // GET: Applicant/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = _repository.GetApplicant(id.Value);
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
            Applicant applicant = _repository.GetApplicant(id);
            _repository.DeleteApplicant(applicant);
            return RedirectToAction("Index");
        }
    }
}
