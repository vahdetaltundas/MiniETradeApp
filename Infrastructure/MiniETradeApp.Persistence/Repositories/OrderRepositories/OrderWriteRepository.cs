using MiniETradeApp.Application.Repositories.CustomerRepositories;
using MiniETradeApp.Domain.Entities;
using MiniETradeApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETradeApp.Persistence.Repositories.OrderRepositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(MiniETradeAppDbContext context) : base(context)
        {
        }
    }
}
