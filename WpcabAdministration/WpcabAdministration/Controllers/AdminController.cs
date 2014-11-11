using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WpcabAdministration.Models;

namespace WpcabAdministration.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContext db = new AppDbContext();
        private List<string> _bloodGroups;
        private List<string> _countries;

        public AdminController()
        {
            _bloodGroups = new List<string>{"A+", "B+", "AB+"};
            _countries = new List<string> { "Bangladesh", "India", "USA" };
        }

        // GET: Admin
        public ActionResult Index()
        {
            var members = db.Members.Include(m => m.Country).Include(m => m.Zone);
            return View(members.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            //ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            ViewBag.CountryId = new SelectList(_countries, "CountryId");
            ViewBag.DistrictId = new SelectList(db.Districts, "DistrictId", "NameEn");
            ViewBag.PoliceStationId = new SelectList(db.PoliceStations, "PoliceStationId", "NameEn");
            ViewBag.PostOfficeId = new SelectList(db.PostOffices, "PostOfficeId", "NameEn");
            ViewBag.VillageId = new SelectList(db.Villages, "VillageId", "NameEn");
            ViewBag.ZoneId = new SelectList(db.Zones, "ZoneId", "NameEn");
            ViewBag.BloodGroup = new SelectList(_bloodGroups, "BloodGroup");
            ViewBag.Relatives = new SelectList(db.Relatives, "Relatives", "NameBn");
            Member aMember = new Member()
            {
                MemberPin = 101,
                Age = 25,
                DateFromInactive = DateTime.Today,
                DateOfBirth = DateTime.Today,
                DateOfMembership = DateTime.Today,
                DateOfPassing = DateTime.Today,
                DateOfLastMonthlyKhedmat = DateTime.Today,
                DateOfLastUpdate = DateTime.Today,
                DataFromKhedmatStarts = DateTime.Today,
            };
            return View(aMember);
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                member.DateFromInactive = DateTime.Today;
                member.DateOfBirth = DateTime.Today;
                member.DateOfMembership = DateTime.Today;
                member.DateOfPassing = DateTime.Today;
                member.DateOfLastMonthlyKhedmat = DateTime.Today;
                member.DateOfLastUpdate = DateTime.Today;
                member.DataFromKhedmatStarts = DateTime.Today;
                member.CountryId = 1;
                member.ZoneId = 1;
                db.Members.Add(member);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BloodGroup = new SelectList(_bloodGroups, "BloodGroup");
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", member.CountryId);
            ViewBag.ZoneId = new SelectList(db.Zones, "ZoneId", "NameEn", member.ZoneId);
            return View(member);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", member.CountryId);
            ViewBag.ZoneId = new SelectList(db.Zones, "ZoneId", "NameEn", member.ZoneId);
            return View(member);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Member member)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", member.CountryId);
            ViewBag.ZoneId = new SelectList(db.Zones, "ZoneId", "NameEn", member.ZoneId);
            return View(member);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Member member = db.Members.Find(id);
            db.Members.Remove(member);
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
