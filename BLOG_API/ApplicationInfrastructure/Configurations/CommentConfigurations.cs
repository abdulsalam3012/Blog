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
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("blogs");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Content).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(t => t.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(t => t.UpdatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.HasOne(t => t.User).WithMany(x => x.Comments).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.Blog).WithMany(x => x.Comments).HasForeignKey(x => x.BlogId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
