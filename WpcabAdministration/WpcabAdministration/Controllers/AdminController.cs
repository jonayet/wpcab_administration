using System;
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

        // GET: Admin
        public ActionResult Index()
        {
            var members = db.Members.Include(m => m.Country).Include(m => m.District).Include(m => m.PoliceStation).Include(m => m.PostOffice).Include(m => m.Village).Include(m => m.Zone);
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
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            ViewBag.DistrictId = new SelectList(db.Districts, "DistrictId", "NameEn");
            ViewBag.PoliceStationId = new SelectList(db.PoliceStations, "PoliceStationId", "NameEn");
            ViewBag.PostOfficeId = new SelectList(db.PostOffices, "PostOfficeId", "NameEn");
            ViewBag.VillageId = new SelectList(db.Villages, "VillageId", "NameEn");
            ViewBag.ZoneId = new SelectList(db.Zones, "ZoneId", "NameEn");
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", member.CountryId);
            ViewBag.DistrictId = new SelectList(db.Districts, "DistrictId", "NameEn", member.DistrictId);
            ViewBag.PoliceStationId = new SelectList(db.PoliceStations, "PoliceStationId", "NameEn", member.PoliceStationId);
            ViewBag.PostOfficeId = new SelectList(db.PostOffices, "PostOfficeId", "NameEn", member.PostOfficeId);
            ViewBag.VillageId = new SelectList(db.Villages, "VillageId", "NameEn", member.VillageId);
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
            ViewBag.DistrictId = new SelectList(db.Districts, "DistrictId", "NameEn", member.DistrictId);
            ViewBag.PoliceStationId = new SelectList(db.PoliceStations, "PoliceStationId", "NameEn", member.PoliceStationId);
            ViewBag.PostOfficeId = new SelectList(db.PostOffices, "PostOfficeId", "NameEn", member.PostOfficeId);
            ViewBag.VillageId = new SelectList(db.Villages, "VillageId", "NameEn", member.VillageId);
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
            ViewBag.DistrictId = new SelectList(db.Districts, "DistrictId", "NameEn", member.DistrictId);
            ViewBag.PoliceStationId = new SelectList(db.PoliceStations, "PoliceStationId", "NameEn", member.PoliceStationId);
            ViewBag.PostOfficeId = new SelectList(db.PostOffices, "PostOfficeId", "NameEn", member.PostOfficeId);
            ViewBag.VillageId = new SelectList(db.Villages, "VillageId", "NameEn", member.VillageId);
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
