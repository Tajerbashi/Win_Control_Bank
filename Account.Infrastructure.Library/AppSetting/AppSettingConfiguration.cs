using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Account.Infrastructure.Library.AppSetting
{
    public static class AppSettingConfiguration
    {
        public static string ConnectionString()
        {
            var basePath = Directory.GetCurrentDirectory();
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(basePath)
                                .AddJsonFile("appsettings.json", reloadOnChange: true, optional: false)
                                .Build();
            var defaultConnection = configuration.GetConnectionString("DefaultConnection");
            return defaultConnection;
        }
    }
}


