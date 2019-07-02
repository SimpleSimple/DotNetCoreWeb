using Microsoft.EntityFrameworkCore;
using MyProject.Core;
using System;

namespace MyProject.EntityFrameworkCore
{
    public class EfDbContext : DbContext
    {
        public EfDbContext()
            : base()
        { }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Goods> Goods { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
