
namespace M5W1.Data
{
    class User
    {
        public string UserName { get; }

        public string Password { get; }

        internal User(){
            UserName = M5W1.Util.Properties.email;
            Password = M5W1.Util.Properties.password;
        }

        internal User(string user, string password) {
            UserName = user;
            Password = password;
        }
    }
}
