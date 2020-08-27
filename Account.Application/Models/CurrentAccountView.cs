using System;

namespace Account.Application.Models
{
    public class CurrentAccountView
    {
        public Guid Id { get; set; }
        public Guid HolderId { get; set; }
        public decimal Amount { get; set; }
    }
}
