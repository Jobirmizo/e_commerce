using ecommerce.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data;

public class eCommerseDbContext : DbContext
{
    public eCommerseDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    
}