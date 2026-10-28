using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._17.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tire {  get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
