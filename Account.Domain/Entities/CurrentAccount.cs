using Account.Domain.BaseProperties;
using Account.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Account.Domain.Entities
{
    public class CurrentAccount : TEntity, IBaseEntity
    {
        private List<EntryAccount> EntryAccounts = new List<EntryAccount>();
        public Guid HolderId { get; private set; }
        public decimal Balance => EntryAccounts.Sum(x =>
        {
            return x.EntryTypeAccount == EntryTypeAccount.Debit ? x.Amount * -1 : x.Amount;
        });

        public CurrentAccount(Guid id, Guid holderId, IEnumerable<EntryAccount> entryAccounts = null)
        {
            if (id == null || id == Guid.Empty)
            {
                throw new ApplicationException("Parâmetro 'Id' obrigatório!");
            }

            if (holderId == null || holderId == Guid.Empty)
            {
                throw new ApplicationException("Parâmetro 'Correntista Id' obrigatório!");
            }
            
            Id = id;
            HolderId = holderId;

            if (entryAccounts != null)
            {
                this.EntryAccounts.AddRange(entryAccounts);
            }
        }

        public void AddEntryAccount(EntryTypeAccount type, decimal amount, DateTime date)
        {
            EntryAccounts.Add(new EntryAccount(type, date, amount));
        }
    }
}

