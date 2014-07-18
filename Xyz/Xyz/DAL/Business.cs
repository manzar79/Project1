using Xyz.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Xyz.Controllers;

namespace Xyz.DAL
{
    public class Business : DbContext
    {
   
    
        public Business() : base("Business")
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}