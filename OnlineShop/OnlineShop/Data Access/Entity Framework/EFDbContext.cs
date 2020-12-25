using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data_Access.Entity_Framework
{
    public class EFDbContext:DbContext
    {
        public EFDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 1,
                Name = "Product 2",
                Price = 30
            });
            SaveChanges();
        }
    }
}
