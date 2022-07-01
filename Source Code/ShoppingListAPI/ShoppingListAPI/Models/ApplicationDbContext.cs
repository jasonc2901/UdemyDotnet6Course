using Microsoft.EntityFrameworkCore;

namespace ShoppingListAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Grocery> Groceries { get; set; }
    }
}
