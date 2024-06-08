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
    public class UserRoleConfigurations : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(t => new { t.UserId,t.RoleId});
            builder.HasOne(t=>t.User).WithMany(u=>u.UserRoles).HasForeignKey(u=>u.UserId);
            builder.HasOne(t=>t.Role).WithMany(u=>u.UserRoles).HasForeignKey(u=>u.RoleId);
        }
    }
}
