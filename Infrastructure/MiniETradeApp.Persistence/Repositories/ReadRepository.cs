using Microsoft.EntityFrameworkCore;
using MiniETradeApp.Application.Repositories;
using MiniETradeApp.Domain.Entities.Common;
using MiniETradeApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniETradeApp.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly MiniETradeAppDbContext _context;

        public ReadRepository(MiniETradeAppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool traking = true)
        {
            var query=Table.AsQueryable();
            if(!traking)
                query=query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool traking = true)
        {
            var query=Table.AsQueryable();
            if(!traking)
                query=query.AsNoTracking();
            return await query.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool traking = true)
        {
            var query = Table.AsQueryable();
            if (!traking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool traking = true)
        {
            var query = Table.Where(expression);
            if (!traking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
