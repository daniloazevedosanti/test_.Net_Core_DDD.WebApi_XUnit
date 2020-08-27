using Account.Domain.BaseProperties;
using System;
using System.Collections.Generic;

namespace Account.Domain.Entities
{
    public class EntryAccount : ValueObject
    {
        public EntryTypeAccount EntryTypeAccount { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime Date { get; private set; }

        public EntryAccount(EntryTypeAccount entryTypeAccount, DateTime date, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ApplicationException("Valor deve ser maior que zero!");
            }

            EntryTypeAccount = entryTypeAccount;
            Amount = amount;
            Date = date;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return EntryTypeAccount;
            yield return Date;
            yield return Amount;
        }
    }
}
