using Microsoft.EntityFrameworkCore;
using Rohan_Phadtare_DotnetAssignment6_CodeFirstAPI.Models;
using System;

namespace Rohan_Phadtare_DotnetAssignment6_CodeFirstAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Peripheral> Peripherals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Peripheral>()
                .Property(p => p.Price)
                .HasPrecision(18, 2); 

            modelBuilder.Entity<Peripheral>().HasData(
                new Peripheral
                {
                    Id = 1,
                    Name = "Mechanical Keyboard RGB",
                    Category = "Keyboard",
                    QuantityInStock = 15,
                    Price = 89.99m,
                    AddedDate = new DateTime(2024, 1, 15, 10, 30, 0, DateTimeKind.Utc) // Static date
                },
                new Peripheral
                {
                    Id = 2,
                    Name = "Wireless Gaming Mouse",
                    Category = "Mouse",
                    QuantityInStock = 25,
                    Price = 49.99m,
                    AddedDate = new DateTime(2024, 1, 20, 14, 15, 0, DateTimeKind.Utc)
                },
                new Peripheral
                {
                    Id = 3,
                    Name = "27-inch 4K Monitor",
                    Category = "Monitor",
                    QuantityInStock = 8,
                    Price = 299.99m,
                    AddedDate = new DateTime(2024, 1, 23, 9, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}