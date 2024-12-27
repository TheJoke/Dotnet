using Atelier2Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Atelier2Application.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }

}
