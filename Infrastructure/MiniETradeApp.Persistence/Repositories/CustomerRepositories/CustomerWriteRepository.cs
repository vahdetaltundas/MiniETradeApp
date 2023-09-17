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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(MiniETradeAppDbContext context) : base(context)
        {
        }
    }
}
