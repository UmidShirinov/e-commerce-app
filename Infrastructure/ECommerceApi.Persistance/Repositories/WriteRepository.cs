using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities.Comman;
using ECommerceApi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistance.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {

        private readonly ECommerceAPIDbContext _context;

        public WriteRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            var entityEntry = await Table.AddAsync(model);

            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);

            return true;
        }

    

        public bool Delete(T model)
        {
            var entityEntry = Table.Remove(model);

            return entityEntry.State == EntityState.Deleted;

        }

        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

            var entry = Table.Remove(entity);

            return entry.State == EntityState.Deleted;
        }

        public bool DeleteRange(List<T> model)
        {
            Table.RemoveRange(model);

            return true;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public bool Update(T model)
        {
            var entry = Table.Update(model);
            return entry.State == EntityState.Modified;
        }
    }
}
