using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MiniETradeApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETradeApp.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MiniETradeAppDbContext>
    {
        public MiniETradeAppDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MiniETradeAppDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new MiniETradeAppDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
