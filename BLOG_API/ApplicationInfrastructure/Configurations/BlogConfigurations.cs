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
    public class BlogConfigurations : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("blogs");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(t => t.Content).IsRequired();
            builder.Property(t => t.Image).IsRequired();
            builder.Property(t => t.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(t => t.UpdatedOn).IsRequired().HasDefaultValue(DateTime.Now); 
            builder.HasOne(t => t.User).WithMany(x=>x.Blogs).HasForeignKey(x=>x.UserId).OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
