using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDBContext:DbContext 
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
