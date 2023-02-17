using BlogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Contracts.Data
{
    public interface IBlogContext
    {
        DbSet<Post> Posts { get; set; }
        DbSet<PostComment> PostComments { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
