using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SBD.Models
{
    public class Cart
    {
        [Key]
        public int id { get; set; }
        [Required]
        public static int quantity { get; set; }
        public int sum = (quantity * item.Price);
        // foreign key
        [Required]
        public static int item { get; set; }
        [ForeignKey("item")]
        public Item itemId { get; set; }
        [Required]
        public int order { get; set; }
        [ForeignKey("order")]
        public Order orderid { get; set; }
    }
}