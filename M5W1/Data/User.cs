using M5W1.M5W1.Util;

namespace M5W1.M5W1.Data
{
    class User
    {
        public string UserName { get; }

        public string Password { get; }

        internal User(){
            UserName = PropertiesGetter.Email;
            Password = PropertiesGetter.Password;
        }

        internal User(string user, string password) {
            UserName = user;
            Password = password;
        }
    }
}
