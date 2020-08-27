using Account.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Account.Application.Services
{
    [DataContract]
    public class GetCurrentAccout : IRequest<CurrentAccountView>
    {
        [DataMember]
        public Guid Id { get; private set; }

        public GetCurrentAccout(Guid id)
        {
            Id = id;
        }
    }
}
