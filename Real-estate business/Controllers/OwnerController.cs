using Real_estate_business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_estate_business.Controllers
{
    public class OwnerController : Controller
    {

        private BusinessContext businessContext = new BusinessContext();
        // GET: Owner
        public ActionResult Index()
        {
            List<Owner> Owners = businessContext.Owners.ToList();
            return View(Owners);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Owner owner)
        {

            businessContext.Owners.Add(owner);
            businessContext.SaveChanges();
            return RedirectToAction("Index");

        }

       
        public ActionResult Edit(string id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerfNo == id);
            ViewBag.OwnerDetails = new SelectList(businessContext.Owners, "OwnerNo", "OwnerNo");
            return View(owner);
        }

        [HttpPost]
        public ActionResult Edit(string id, Owner updatedOwner)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerfNo == id);
            owner.OwnerfNo = updatedOwner.OwnerfNo;
            owner.Fname = updatedOwner.Fname;
            owner.Lname = updatedOwner.Lname;
            owner.Address = updatedOwner.Address;
            owner.TelNo = updatedOwner.TelNo;
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerfNo == id);
            return View(owner);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedOwner(string id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerfNo == id);
            businessContext.Owners.Remove(owner);
            businessContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Detail(string id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerfNo == id);
            return View(owner);
        }
    }
}