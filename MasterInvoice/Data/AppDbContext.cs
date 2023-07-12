using MasterInvoice.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterInvoice.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<ECustomer> Customers { get; set; }
        public DbSet<EItem> Items { get; set; }
    }
}
