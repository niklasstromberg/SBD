using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SBD.Models
{
    public class Adress
    {
        public int id { get; set; }
        [Required]
        public string adress1 { get; set; }
        public string adress2 { get; set; }
        [Required]
        public int zipcode { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string country { get; set; }

        public ICollection<User> Users { get; set; }
    }
}