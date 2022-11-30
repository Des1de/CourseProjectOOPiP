using MyFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFood.Services
{
    public class AccountCreationService
    {
        public async Task<UserInfo> CreateAccountAsync(string login, string password, string repeatPassword)
        {
            return await TempServer.CreateAccountAsync(login, password, repeatPassword);
        }
    }
}
