using AppDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        { 
            builder.ToTable("users");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Username).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(t => t.Password).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(t => t.Email).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)").HasAnnotation("RegularExpression", "/^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,})$/");
            builder.HasMany(t => t.UserRoles).WithOne(ur=>ur.User).HasForeignKey(x=>x.UserId);
        }
    }
}
