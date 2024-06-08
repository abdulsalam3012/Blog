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
    public class RoleConfigurations : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(t => t.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(t => t.UpdatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.HasMany(x => x.UserRoles).WithOne(x => x.Role).HasForeignKey(x => x.RoleId);
            builder.HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 1, Name = "User" }
                );
        }
    }
}
