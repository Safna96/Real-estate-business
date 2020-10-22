using System;
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
        public string OwnerNoRef { get; set; }
        public string StaffNoRef { get; set; }
        public string BranchNoRef { get; set; }
        public int Rent1 { get; set; }
    }
}