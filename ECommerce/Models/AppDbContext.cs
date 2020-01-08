using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
    }


}
