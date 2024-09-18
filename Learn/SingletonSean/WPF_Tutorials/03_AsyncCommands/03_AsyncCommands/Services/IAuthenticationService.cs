namespace _03_AsyncCommands.Services
{
    public interface IAuthenticationService
    {
        Task Login(string username);
    }
}
