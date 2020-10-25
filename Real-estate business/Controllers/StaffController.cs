using Real_estate_business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_estate_business.Controllers
{
    public class StaffController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Rent
        public ActionResult Index()
        {
            List<Staff> Allstaffs = businessContext.Staffs.ToList();
            return View(Allstaffs);
        }

        public ActionResult Create()
        {
            ViewBag.BranchDetails = businessContext.Branches;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            ViewBag.BranchDetails = businessContext.Branches;
            businessContext.Staffs.Add(staff);
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            ViewBag.BranchDetails = new SelectList(businessContext.Staffs, "Branch_BranchNoRef", "Branch_BranchNoRef");
            return View(staff);
        }

        [HttpPost]
        public ActionResult Edit(string id, Staff updatedStaff)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            staff.StaffNo = updatedStaff.StaffNo;
            staff.Fname = updatedStaff.Fname;
            staff.Lname = updatedStaff.Lname;
            staff.Position = updatedStaff.Position;
            staff.DOB = updatedStaff.DOB;
            staff.Salary = updatedStaff.Salary;
            staff.Branch_BranchNoRef = updatedStaff.Branch_BranchNoRef;
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletedStaff(string id)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            businessContext.Staffs.Remove(staff);
            businessContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Details(string id)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }

        public ActionResult IndexQ()
        {
            List<Staff> staff = businessContext.Staffs.ToList();
            return View(staff);

        }
    }
}