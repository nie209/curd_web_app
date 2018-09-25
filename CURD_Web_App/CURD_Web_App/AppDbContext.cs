using Microsoft.EntityFrameworkCore;

namespace CURD_Web_App
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {
                        
            
        }
        public DbSet<Customer> Customers { get; set; }
        
    }
}