using Account.Domain.Entities;
using System;

namespace Account.Domain.Services
{
    public class ServiceAccount
    {
        public void Transaction(CurrentAccount source, CurrentAccount destiny,
                                DateTime date, decimal amount)
        {
            if (source == destiny)
            {
                throw new ApplicationException("ERRO: Conta origem e destino são iguais!");
            }

            if (source.Balance < amount)
            {
                throw new ApplicationException("Saldo insuficiente para realizar esta operação!");
            }

            source.AddEntryAccount(EntryTypeAccount.Debit, amount, date);
            destiny.AddEntryAccount(EntryTypeAccount.Debit, amount, date);
        }
    }
}
