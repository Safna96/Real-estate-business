using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Real_estate_business.Models
{
    public class BusinessContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}