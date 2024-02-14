using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Account.Presentation.ServiceContainer
{
    public static class AppSettings
    {
        public static ConnectionStrings ConnectionStrings(this IServiceCollection services)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            string connString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<IContextDbApplication, ContextDbApplication>(options =>
                options.UseSqlServer(connString),
                ServiceLifetime.Transient);
            return new ConnectionStrings
            {
                DefaultConnection = connString
            };
        }
    }
    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }
}
