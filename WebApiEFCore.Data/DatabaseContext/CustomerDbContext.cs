using Microsoft.EntityFrameworkCore;
using WebApiEFCore.Data.Configuration;
using WebApiEFCore.Model;

namespace WebApiEFCore.Data.DatabaseContext
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
