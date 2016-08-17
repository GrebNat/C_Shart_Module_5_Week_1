using static M5W1.Properties.Settings;

namespace M5W1.Util
{
    public class Properties
    {
        public static string email => Default["email"].ToString();
        public static string url => Default["url"].ToString();
        public static string password => Default["password"].ToString();
        public static string browser => Default["browser"].ToString();
       
    }
}