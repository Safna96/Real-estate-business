using Real_estate_business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_estate_business.Controllers
{
    public class BranchController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Branch
        public ActionResult Index()
        {
            List<Branch> AllBranches = businessContext.Branches.ToList();
            return View(AllBranches);
        }


        public ActionResult Create()
        {
            ViewBag.BranchDetails = businessContext.Branches;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Branch branch)
        {
            ViewBag.BranchDetails = businessContext.Branches;
            businessContext.Branches.Add(branch);
            businessContext.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult Edit(string id)
        {
            Branch branch = businessContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            ViewBag.BranchDetails = new SelectList(businessContext.Branches, "BranchNo", "BranchNo");
            return View(branch);
        }

        [HttpPost]
        public ActionResult Edit(string id, Branch updatedBranch)
        {
            Branch branch = businessContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            branch.BranchNo = updatedBranch.BranchNo;
            branch.Street = updatedBranch.Street;
            branch.City = updatedBranch.City;
            branch.Postcode = updatedBranch.Postcode;
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }
        

        public ActionResult Delete(string id)
        {
            Branch branch = businessContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedBranch(string id)
        {
            Branch branch = businessContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            businessContext.Branches.Remove(branch);
            businessContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Details(string id)
        {
            Branch branch = businessContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }
    }
}