using Microsoft.EntityFrameworkCore;

namespace oopveb8.Models
{
    
    
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<User> Users { get; set; } // Додайте DbSet для вашої моделі User
        }
}
