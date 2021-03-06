﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Real_estate_business.Models
{
    [Table("Rent_tbl")]
    public class Rent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PropertyNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Ptype{ get; set; }
        public int Rooms { get; set; }

        [ForeignKey("Owner")]
        public string OwnerNoRef { get; set; }
        public virtual Owner Owner { get; set; }

        [ForeignKey("Staff")]
        public string StaffNoRef { get; set; }
        public virtual Staff Staff { get; set; }


        [ForeignKey("Branch")]
        public string BranchNoRef { get; set; }
        public virtual Branch Branch { get; set; }

        public double Rent1 { get; set; }
    }
}