using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities.Comman;
using ECommerceApi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIDbContext _context;

        public ReadRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true) // return type olaraq Iqueryable vermisense onu asqueable nan cevirmelisen.
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query =  Table.AsQueryable();

            if (!tracking)
                query.AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable().Where(method);
            if (!tracking) query.AsNoTracking();
            return query;

        }
        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        // => await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
        //Asquarable da Find methodu ishlenmir

        {
            var query = Table.AsQueryable();
            if (!tracking) query.AsNoTracking();
            return await query.FirstOrDefaultAsync(x => x.Id==Guid.Parse(id));
        }

    }
}
