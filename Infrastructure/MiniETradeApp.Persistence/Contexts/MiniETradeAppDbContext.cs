using Microsoft.EntityFrameworkCore;
using MiniETradeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETradeApp.Persistence.Contexts
{
    public class MiniETradeAppDbContext : DbContext
    {
        public MiniETradeAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
