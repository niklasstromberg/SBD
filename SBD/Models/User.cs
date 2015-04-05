using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SBD.Models
{
    public class User
    {
        [Key, ForeignKey("Item")]
        public int id { get; set; }
        public string company { get; set; }
        [Required]
        [Column("Förnamn")]
        public string firstName { get; set; }
        [Required]
        [Column("Efternamn")]
        public string lastName { get; set; }
        public Int64 pnr { get; set; }
        public Int64 phone { get; set; }
        public Int64 mobile { get; set; }
        [EmailAddress]
        public string email { get; set; }
        // foreign keys
        [Required]
        public int deliveryAdress { get; set; }
        [ForeignKey("deliveryadress")]  
        public Adress AdressDel { get; set; }
        [Required]
        public int billingAdress { get; set; }
        [ForeignKey("billingAdress")]
        public Adress AdressBil { get; set; }

    }
}