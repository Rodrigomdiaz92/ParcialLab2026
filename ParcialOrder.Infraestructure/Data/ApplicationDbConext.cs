using Microsoft.EntityFrameworkCore;
using ParcialOrder.Domain.Aggregates
    ;

namespace ParcialOrder.Infraestructure.Data
{
    public class ApplicationDbConext : DbContext
    {
        public ApplicationDbConext(DbContextOptions<ApplicationDbConext> options) : base(options)
        {
        }
        //public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            // Configure entity relationships and constraints here 
            //modelBuilder.Entity<Product>().ToTable("Products").Property(p => p.Name).HasMaxLength(100);
            modelBuilder.Entity<Order>().ToTable("Orders").OwnsOne(o => o.Address);
            //modelBuilder.Entity<OrderItem>().ToTable("OrderItems");
            //modelBuilder.Entity<Customer>().ToTable("Customers").OwnsOne(c => c.Address);


            base.OnModelCreating(modelBuilder);
        }
    }
}
