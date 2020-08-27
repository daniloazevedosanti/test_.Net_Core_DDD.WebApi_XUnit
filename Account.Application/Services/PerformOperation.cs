using MediatR;
using System;
using System.Runtime.Serialization;

namespace Account.Application.Services
{
    [DataContract]
    public class PerformOperation : IRequest<CommandResult>
    {
        [DataMember]
        public Guid AccountSourceId { get; private set; }
        
        [DataMember]
        public Guid AccountDestinyId { get; private set; }
        
        [DataMember]
        public decimal Amount { get; private set; }
        
        public PerformOperation(Guid sourceId, Guid destinyId, decimal amount)
        {
            AccountSourceId = sourceId;
            AccountDestinyId = destinyId;
            Amount = amount;
        }
    }
}
