using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Account.Domain.Interfaces
{
    public interface IRepository<T> where T : IBaseEntity
    {
        void Add(T Obj);
        void Update(T Obj);
        void Delete(T Obj);
        Task<T> FindByIdAsync(Guid ObjId);
        Task<IEnumerable<T>> GetAll();
    }
}
