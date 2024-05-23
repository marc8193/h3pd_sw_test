using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EFCoreExample
{
    public class AppDBContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        public AppDBContext() : base()
        {
            System.Console.WriteLine("AppDBContext");
        }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            System.Console.WriteLine("AppDBContext II");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            var con_str = "server=127.0.0.1;database=H1PD040124_pmad;user id=H1PD040124_pmad;pwd=H1PD040124_pmad;Encrypt=False;Trusted_Connection=False";
            var con_str = "server=127.0.0.1;database=H1PD040124_Gruppe1;user id=H1PD040124_Gruppe1;pwd=H1PD040124_Gruppe1;Encrypt=False;Trusted_Connection=False";

            optionsBuilder.UseSqlServer(con_str);
            // optionsBuilder.LogTo(Console.WriteLine);
            System.Console.WriteLine("OnConfiguring");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            System.Console.WriteLine("OnModelCreating");
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}