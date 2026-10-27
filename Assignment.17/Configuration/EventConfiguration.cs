using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment._17.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment._17.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(E => E.EventId);
            builder.Property(E => E.Title).HasColumnType("Varchar(50)");
            builder.Property(E => E.Description).HasColumnType("Varchar(200)");
            builder.Property(E => E.StartDate).HasDefaultValueSql("GETDATE()");
            builder.Property(E => E.EndDate).IsRequired(false);
        }
    }
}