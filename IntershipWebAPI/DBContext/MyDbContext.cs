using IntershipWebAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace IntershipWebAPI.DBContext
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { 
            
        }
        public DbSet<Test> TestInfo { get; set; }
        public DbSet<State> State { get; set; }

        public DbSet<Login> Login { get; set; }
        public DbSet<InvoiceType> InvoiceType { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
