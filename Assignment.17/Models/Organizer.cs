using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._17.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int OrganizerId { get; set; }
        [MaxLength(100)]
        [Required]
        public string OrganizerName { set; get; }
        [MaxLength(150)]
        public string? companyName { set; get; }
        public bool Isverified { set; get;  }
        public int OrganizerProfileId { set; get; }
        public OrganizerProfile OrganizerProfile { set; get; }
        public Event Event { set; get; }
    }
}
