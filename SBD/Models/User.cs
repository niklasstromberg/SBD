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
        [Key]
        public int id { get; set; }
        public string company { get; set; }
        [Required]
        [Column("Förnamn")]
        public string firstName { get; set; }
        [Required]
        [Column("Efternamn")]
        public string lastName { get; set; }
        public Int64 pnr { get; set; }
        public Int64 telefon { get; set; }
        public Int64 mobil { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [ForeignKey("Adress")]
        public int AdressLeverans { get; set; }
        [Required]
        [ForeignKey("Adress")]
        public int AdressFakturering { get; set; }

    }
}