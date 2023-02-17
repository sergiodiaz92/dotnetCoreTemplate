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
    public class PostCommentMap : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Body)
                .HasColumnType("varchar(max)")
                .IsRequired();
            builder.Property(e => e.PostId)
                .IsRequired();

            builder.HasOne(e=>e.Post)
                .WithMany(e => e.Comments)
                .HasForeignKey(e => e.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostComment_Post");
        }
    }
}
