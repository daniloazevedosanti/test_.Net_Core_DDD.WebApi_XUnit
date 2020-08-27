
namespace Account.Application.Services
{
    public class CommandResult
    {
        public CommandResult(bool success, string mensagem = null)
        {
            Success = success;
            Message = mensagem;
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
    }
}