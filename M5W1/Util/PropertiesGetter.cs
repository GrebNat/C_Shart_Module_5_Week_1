using System.Runtime.CompilerServices;
using static M5W1.Properties.Settings;


namespace M5W1.Util
{
    class PropertiesGetter
    {
        public static string email => Default["email"].ToString();
        public static string url => Default["url"].ToString();
        public static string password => Default["password"].ToString();
        public static string browser => Default["browser"].ToString();
       
    }
}