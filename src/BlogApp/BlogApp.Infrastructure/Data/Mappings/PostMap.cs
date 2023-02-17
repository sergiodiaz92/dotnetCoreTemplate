using BlogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Infrastructure.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e=>e.Title).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Body).HasColumnType("varchar(max)").IsRequired();
            builder.Property(e=>e.Locked).HasDefaultValue(false);
            
        }
    }
}
