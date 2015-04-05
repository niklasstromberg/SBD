using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SBD.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public int costToMake { get; set; }
        public int weight { get; set; }
        public string itemImage { get; set; }
        public string description { get; set; }
        // foreign key
        [Required]
        public int manufacturer { get; set; }
        [ForeignKey("manufacturer")]
        public User Userid { get; set; }
    }
}