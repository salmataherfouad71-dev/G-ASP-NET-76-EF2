using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._17.Models
{
    public class OrganizerProfile
    {
        public int ProfileId { get; set; }
        public string Biography { set; get; }
        public string WebsiteLink { set; get; }
        public string LogoLink {  set; get; }
        public Organizer Organizer { set; get; }
    }
}
