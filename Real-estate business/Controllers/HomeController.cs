using Real_estate_business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_estate_business.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private BusinessContext businessContext = new BusinessContext();
        public ActionResult Index()
        {
            List<Branch> AllBranches = businessContext.Branches.ToList();
            return View(AllBranches);
        }

        public ActionResult StaffDetail()
        {
            List<Staff> AllStaffs = businessContext.Staffs.ToList();
            return View(AllStaffs);
        }

        public ActionResult RentDetail()
        {
            List<Rent> AllRents = businessContext.Rents.ToList();
            return View(AllRents);
        }

        public ActionResult OwnerDetail()
        {
            List<Owner> AllOwners = businessContext.Owners.ToList();
            return View(AllOwners);
        }

    }
}