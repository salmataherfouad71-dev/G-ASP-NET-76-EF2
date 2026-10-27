using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment._17.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment._17
{
    public class EventHubDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=EventHub; Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Attendee> Attendees { set; get; }
        public DbSet<Badge> Badges { set; get; }
        public DbSet<Event> Events { set; get; }
        public DbSet<Organizer> Organizers{ set; get; }
        public DbSet<OrganizerProfile> OrganizerProfiles { set; get; }
    }
}
