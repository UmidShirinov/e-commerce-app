using ECommerceApi.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);
        Task<bool> DeleteAsync(string id);
        bool Delete(T model);
        bool DeleteRange(List<T> model);
        bool Update(T model);

        Task<int> SaveAsync();

    }

}
