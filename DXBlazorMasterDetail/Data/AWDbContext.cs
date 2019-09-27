using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DXBlazorMasterDetail.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace DXBlazorMasterDetail.Data
{
    public class AWContext : DbContext
    {
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<ProductOrderLine> ProductOrderLine { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dbPath = Path.Combine(Utils.GetWebHostEnvironment().ContentRootPath, "adventureworks.db");
                optionsBuilder.UseSqlite("Data Source=" + dbPath);
            }
        }
    }
}