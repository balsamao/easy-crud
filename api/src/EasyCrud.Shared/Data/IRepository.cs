using EasyCrud.Shared.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyCrud.Shared.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        Task<List<T>> GetAll();
        Task<T> GetById(long id);
        Task<long> Insert(T entity);
        Task Update(T entity);
        Task Remove(long id);
    }
}
