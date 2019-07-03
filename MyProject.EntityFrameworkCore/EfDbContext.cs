using Microsoft.EntityFrameworkCore;
using MyProject.Core;
using System;
using System.Configuration;

namespace MyProject.EntityFrameworkCore
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options)
            : base(options)
        { }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Goods> Goods { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        }
    }
}
