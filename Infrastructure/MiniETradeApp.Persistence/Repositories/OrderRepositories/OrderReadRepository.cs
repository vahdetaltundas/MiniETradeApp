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
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(MiniETradeAppDbContext context) : base(context)
        {
        }
    }
}
