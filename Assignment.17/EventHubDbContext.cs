using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<OrganizerProfile>(O => 
            {
                O.HasKey(O => O.ProfileId);
                O.Property(O => O.Biography).HasColumnType("Varchar(150)");
                O.Property(O => O.WebsiteLink).HasColumnType("Varchar(100)")
                                              .HasColumnName("SiteLink");
                O.Property(O => O.LogoLink).HasColumnType("Varchar(100)");
            });
        }
    }
}
