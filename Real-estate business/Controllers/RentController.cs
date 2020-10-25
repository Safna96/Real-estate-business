using Real_estate_business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_estate_business.Controllers
{
    public class RentController : Controller
    {
        
        private BusinessContext businessContext = new BusinessContext();
        // GET: Rent
        public ActionResult Index()
        {
            List<Rent> AllRents = businessContext.Rents.ToList();
            return View(AllRents);
        }

        public ActionResult Create()
        {
            ViewBag.OwnerDetails = businessContext.Owners;
            ViewBag.StaffDetails = businessContext.Staffs;
            ViewBag.BranchDetails = businessContext.Branches;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            ViewBag.OwnerDetails = businessContext.Owners;
            ViewBag.StaffDetails = businessContext.Staffs;
            ViewBag.BranchDetails = businessContext.Branches;
            businessContext.Rents.Add(rent);
            businessContext.SaveChanges();
            return RedirectToAction("Index");

        }

        

        public ActionResult Edit(string id)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            ViewBag.OwnerDetails = new SelectList(businessContext.Rents, "OwnerNoRef", "OwnerNoRef");
            ViewBag.StaffDetails = new SelectList(businessContext.Rents, "StaffNoRef", "StaffNoRef");
            ViewBag.BranchDetails = new SelectList(businessContext.Rents, "BranchNoRef", "BranchNoRef");
            return View(rent);
        }

        [HttpPost]
        public ActionResult Edit(string id, Rent updatedRent)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            rent.PropertyNo = updatedRent.PropertyNo;
            rent.Street = updatedRent.Street;
            rent.City = updatedRent.City;
            rent.Ptype = updatedRent.Ptype;
            rent.Rent1 = updatedRent.Rent1;
            rent.Rooms = updatedRent.Rooms;
            rent.OwnerNoRef = updatedRent.OwnerNoRef;
            rent.StaffNoRef = updatedRent.StaffNoRef;
            rent.BranchNoRef = updatedRent.BranchNoRef;
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rent);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedRent(string id)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            businessContext.Rents.Remove(rent);
            businessContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult City()
        {
            List<Rent> rent = businessContext.Rents.ToList();
            return View(rent);

        }

        public ActionResult Counts(string branch)
        {
            List<Rent> rent = businessContext.Rents.ToList();
            return View(rent);

        }

        public ActionResult Details(string id)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rent);
        }
    }
}