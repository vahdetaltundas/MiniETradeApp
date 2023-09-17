using MiniETradeApp.Application.Repositories.CustomerRepositories;
using MiniETradeApp.Domain.Entities;
using MiniETradeApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETradeApp.Persistence.Repositories.CustomerRepositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(MiniETradeAppDbContext context) : base(context)
        {
        }
    }
}
