using MyFood.Model;

namespace MyFood.Services
{
    public class AuthorizationService
    {
        public async Task<UserInfo> DoAuthorizationAsync(string login, string password)
        {
            return await TempServer.AuthorizationAsync(login, password);
        }
    }
}
