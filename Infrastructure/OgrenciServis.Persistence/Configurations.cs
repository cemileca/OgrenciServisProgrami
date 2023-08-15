

using System.Configuration;

namespace OgrenciServis.Persistence
{
    public static class Configurations
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["PostgreSQL"].ConnectionString;
            }
        }
    }
}
