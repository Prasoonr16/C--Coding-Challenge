using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Util
{
    public static class DBConnection
    {
        private static IConfigurationRoot _configuration;
        static string s = null;

        static DBConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("C:\\Users\\HP\\source\\repos\\InsuranceManagementSystem\\Util\\appsettingsjson.json",
                optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }
        public static string ReturnCn(string key)
        {
            s = _configuration.GetConnectionString("dbCn");
            return s;
        }

    }
}
