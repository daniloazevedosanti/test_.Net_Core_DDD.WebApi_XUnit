using MediatR;
using System;
using System.Runtime.Serialization;


namespace Account.Application.Services
{
    [DataContract]
    public class CreatedCurrentAccount : IRequest<CommandResult>
    {
        [DataMember]
        public Guid Id { get; private set; }
        [DataMember]
        public Guid HolderId { get; private set; }
        [DataMember]
        public decimal Amount { get; private set; }

        public CreatedCurrentAccount (Guid id, Guid holderId, decimal amount)
        {
            Id = id;
            HolderId = holderId;
            Amount = amount;
        }
    }
}
