using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class StoreEntities : DbContext
    {
        public StoreEntities() : base("StoreDbConnexionString")
        {
            Database.SetInitializer<StoreEntities>(new DropCreateDatabaseAlways<StoreEntities>());
           
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }

    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    //Configure default schema
    //    //modelBuilder.HasDefaultSchema("Admin");

    //    //Map entity to table
    //    modelBuilder.Entity<Product>().ToTable("Product");
    //    modelBuilder.Entity<Genre>().ToTable("Genre", "dbo");
    //    modelBuilder.Entity<Brand>().ToTable("Brand", "dbo");
    //    modelBuilder.Entity<Cart>().ToTable("Cart", "dbo");
    //    modelBuilder.Entity<Order>().ToTable("Order", "dbo");
    //    modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail", "dbo");
        
    //}
}