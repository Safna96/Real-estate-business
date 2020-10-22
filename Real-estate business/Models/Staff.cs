using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Real_estate_business.Models
{
    [Table("Staff_tbl")]
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StaffNo { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Position { get; set; }
        public DateTime DOB { get; set; }
        public int Salary { get; set; }
        [ForeignKey("Department")]
        public string Branch_BranchNoRef { get; set; }

    }
}