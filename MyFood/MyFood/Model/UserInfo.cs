using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFood.Model
{
    public class UserInfo
    {
        public string Login { get; set; }
        public string ErrorMessage { get; set; }
        public UserInfo(string login, string error)
        {
            Login = login;
            ErrorMessage = error;
        }
    }
}
