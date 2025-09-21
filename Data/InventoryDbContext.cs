using Microsoft.EntityFrameworkCore;
using groupActivity.Models;

namespace groupActivity.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryItem> InventoryItems { get; set; }
    }
}