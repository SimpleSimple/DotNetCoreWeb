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
        // 不使用构造函数方式，使用 OnConfiguring 方法
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {
        }

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

            //// 注意：这里获取appsettings.json文件要复制到本地
            ////var config = new ConfigurationBuilder()
            ////    .SetBasePath(Directory.GetCurrentDirectory())
            ////    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            ////    .Build();
            //// 连接SqlServer
            //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
