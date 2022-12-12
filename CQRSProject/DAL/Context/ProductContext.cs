using System;
using CQRSProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL.Context
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=CQRSDb;Username=postgres;Password=postgres");

        public DbSet<Product> Products { get; set; }
    }

    
}
