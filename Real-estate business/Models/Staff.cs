﻿using System;
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

        [Column(TypeName="Date")]
        public DateTime DOB { get; set; }
        public float Salary { get; set; }

        [ForeignKey("Branch")]
        public string Branch_BranchNoRef { get; set; }
        public virtual Branch Branch { get; set; }

    }
}