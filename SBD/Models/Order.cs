using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SBD.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public int frakt { get; set; }
        public int total { get; set; }
        public bool betald { get; set; }
        // foreign keys
        [Required]
        public int buyer { get; set; }
        [ForeignKey("buyer")]
        public User userBuyer { get; set; }
        [Required]
        public int seller { get; set; }
        [ForeignKey("seller")]
        public User userSeller { get; set; }
    }
}