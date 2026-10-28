using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._17.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        [MaxLength(150)]
        [Required]
        public string FullName { get; set; }
        [MaxLength(200)]
        [Required]
        public string EmailAddress { get; set; }
        [MaxLength(150)]
        [Required]
        public string Street { get; set; }
        [MaxLength(100)]
        [Required]
        public string city { get; set; }
        [MaxLength(100)]
        [Required]
        public string Country { get; set; }
        [MaxLength(20)]
        [Required]
        [Column("ZipCode")]
        public string PostalCode { get; set; }
        [NotMapped]
        public string fullAddress;
        [NotMapped]
        public string FullAddress
        {
            get { return $"{Street},{city},{Country},[{PostalCode}]"; }
        }
        public Badge Badge { get; set; }
    }
}
