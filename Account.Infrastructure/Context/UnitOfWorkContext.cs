using Account.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Account.Infrastructure.Context
{
    public class UnitOfWorkContext : IUnitOfWork
    {
        
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(1);
        }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(true);
        }

        public void Dispose()
        {
        }
    }
}

