namespace _03_AsyncCommands.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task Login(string username)
        {
            await Task.Delay(5000);
        }
    }
}
