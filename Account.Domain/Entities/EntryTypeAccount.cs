
using Account.Domain.BaseProperties;

namespace Account.Domain.Entities
{
    public class EntryTypeAccount : Enumeration
    {
        public static EntryTypeAccount Debit = new EntryTypeAccount(1, "Débito");
        public static EntryTypeAccount Credit = new EntryTypeAccount(2, "Crédito");

        public EntryTypeAccount(int id, string name)
        : base(id, name)
        {
        }
    }
}
