using Microsoft.EntityFrameworkCore;
using zoo_management.Models.Database;

namespace zoo_management
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options)
        {
        }
        
        public DbSet<Animal> Animals { get; set; }
    }
}