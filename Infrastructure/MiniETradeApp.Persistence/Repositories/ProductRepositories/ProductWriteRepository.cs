using MiniETradeApp.Application.Repositories.ProductRepositories;
using MiniETradeApp.Domain.Entities;
using MiniETradeApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETradeApp.Persistence.Repositories.ProductRepositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(MiniETradeAppDbContext context) : base(context)
        {
        }
    }
}
