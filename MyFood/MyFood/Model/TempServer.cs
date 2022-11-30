



using MyFood.GlobalConst;
using System.Text.Json;

namespace MyFood.Model
{
    public class TempServer
    {
        static readonly string path = FileSystem.Current.AppDataDirectory;
        static readonly string fullPath = Path.Combine(path, "UserData.json");

        static readonly Dictionary<string, string> _users;
        static readonly List<Dish> _dishes;
        static Dictionary<string, string> ReadUsers()
        {
            Dictionary<string, string> users;
            using (FileStream fs = new(fullPath, FileMode.OpenOrCreate))
            {
                try
                {
                    users = JsonSerializer.Deserialize<Dictionary<string, string>>(fs);
                }
                catch (Exception)
                {
                    users = new Dictionary<string, string>();
                }
            }
            return users;
        }

        static void WriteUsers(Dictionary<string, string> users)
        {
            using (FileStream fs = new(fullPath, FileMode.Create))
            {
                JsonSerializer.Serialize<Dictionary<string, string>>(fs, users);
            }
        }

        static TempServer()
        {
            _users = ReadUsers();


            _dishes = new()
            {
                new Dish(1, "kolbasa1", 11.3, "eto kolbasa1", "kolbasa.jpg"),
                new Dish(2, "kolbasa2", 12.3, "eto kolbasa2", "kolbasa.jpg"),
                new Dish(3, "kolbasa3", 13.3, "eto kolbasa3", "kolbasa.jpg"),
                new Dish(4, "kolbasa4", 14.3, "eto kolbasa4", "kolbasa.jpg"),
                new Dish(5, "kolbasa5", 15.3, "eto kolbasa5", "kolbasa.jpg"),
                new Dish(6, "kolbasa6", 16.3, "eto kolbasa6", "kolbasa.jpg"),
                new Dish(7, "kolbasa7", 17.3, "eto kolbasa7", "kolbasa.jpg")
            };
        }
        public async static Task<UserInfo> AuthorizationAsync(string login, string password)
        {
            await Task.Delay(1);
            if (login == null || password == null || login == "" || password == "") return new UserInfo(login,
                AccountErrorMessages.FIELDS_EMPTY);
            if (!_users.ContainsKey(login) || _users[login] != password) return new UserInfo(login,
                AccountErrorMessages.INCORRECT_LOGIN_OR_PASSWORD);
            return new UserInfo(login, AccountErrorMessages.SUCCESS);
        }
        public async static Task<UserInfo> CreateAccountAsync(string login, string password, string repeatPassword)
        {
            await Task.Delay(1);
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
                return new UserInfo(login, AccountErrorMessages.FIELDS_EMPTY);
            if (_users.ContainsKey(login)) return new UserInfo(login, AccountErrorMessages.SAME_LOGIN_EXIST);
            if (password != repeatPassword) return new UserInfo(login, AccountErrorMessages.PASSWORDS_NOT_SAME);
            _users.Add(login, password);
            WriteUsers(_users);
            return new UserInfo(login, AccountErrorMessages.SUCCESS);
        }

        public async static Task<List<Dish>> GetDishesAsync()
        {
            await Task.Delay(1);
            return _dishes;
        }
        public static List<Dish> GetDishes()
        {
            return _dishes;
        }
    }
}
