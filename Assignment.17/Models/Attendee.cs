using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._17.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Street { get; set; }
        public string city { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
