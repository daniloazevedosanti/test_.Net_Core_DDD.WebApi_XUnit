using Account.Domain.Entities;
using Account.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Infrastructure.Context
{
    public class CurrentAccountContext : ICurrentAccount
    {
        private readonly Dictionary<Guid, CurrentAccount> currentAccounts;

        public CurrentAccountContext()
        {
            currentAccounts = new Dictionary<Guid, CurrentAccount>();
        }

        public void Add(CurrentAccount currentAccount)
        {
            if (!currentAccounts.ContainsKey(currentAccount.Id))
            {
                currentAccounts.Add(currentAccount.Id, currentAccount);
            }
            else
            {
                throw new InvalidOperationException($"Erro ao incluir conta corrente, é existente ou outro problema: '{currentAccount.Id}'");
            }
        }

        public void Delete(CurrentAccount currentAccount)
        {
            if (currentAccounts.ContainsKey(currentAccount.Id))
            {
                currentAccounts.Remove(currentAccount.Id);
            }
        }

        public Task<CurrentAccount> FindByIdAsync(Guid id)
        {
            CurrentAccount result = null;

            if (currentAccounts.ContainsKey(id))
            {
                result = currentAccounts[id];
            }

            return Task.FromResult(result);
        }

        public Task<IEnumerable<CurrentAccount>> GetAll()
        {
            var result = currentAccounts.Values.AsEnumerable();
            return Task.FromResult(result);
        }

        public void Update(CurrentAccount currentAccount)
        {
            if (currentAccounts.ContainsKey(currentAccount.Id))
            {
                currentAccounts[currentAccount.Id] = currentAccount;
            }
            else
            {
                throw new InvalidOperationException($"Erro ao atualizar conta corrente: '{currentAccount.Id}' não encontrada!");
            }
        }

    }
}

