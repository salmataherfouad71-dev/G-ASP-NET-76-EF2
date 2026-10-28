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
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(B=>B.Id);
            builder.Property(B => B.Tire).HasColumnType("Varchar(20)")
                                         .IsRequired(true); 
            builder.Property(B => B.IssuedDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
