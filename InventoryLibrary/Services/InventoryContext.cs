    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using InventoryManagementSystem.Models;
    using Microsoft.EntityFrameworkCore;

    namespace InventoryManagementSystem.Services
    {
        public class InventoryContext:DbContext
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Supplier> Suppliers { get; set; }
            public DbSet<Transaction> Transactions { get; set; }
            public DbSet<Inventory> Inventories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        }
    }
