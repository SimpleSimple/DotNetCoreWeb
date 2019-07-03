using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyProject.Core;
using System;
using System.Configuration;
using System.IO;

namespace MyProject.EntityFrameworkCore
{
    public class EfDbContext : DbContext
    {
        //public EfDbContext(DbContextOptions<EfDbContext> options)
        //    : base(options)
        //{ }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Goods> Goods { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
