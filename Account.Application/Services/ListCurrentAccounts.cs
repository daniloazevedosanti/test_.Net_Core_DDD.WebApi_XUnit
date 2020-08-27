using Account.Application.Models;
using MediatR;

namespace Account.Application.Services
{
    public class ListCurrentAccounts : IRequest<CurrentAccountView[]>
    {
    }
}
