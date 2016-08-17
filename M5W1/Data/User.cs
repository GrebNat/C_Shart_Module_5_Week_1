using static M5W1.Util.PropertiesGetter;

namespace M5W1.Data
{
    class User
    {
        public string UserName { get; }

        public string Password { get; }

        internal User(){
            UserName = email;
            Password = password;
        }

        internal User(string user, string password) {
            UserName = user;
            Password = password;
        }
    }
}
