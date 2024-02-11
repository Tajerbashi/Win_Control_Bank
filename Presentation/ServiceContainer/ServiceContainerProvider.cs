using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation;
using Account.Infrastructure.Library.ApplicationContext.GridDataConnection;
using Account.Applicatino.Library.Patterns;
using Account.Application.Library.Patterns;

namespace Account.Presentation.ServiceContainer
{
    public class ServiceContainerProvider
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureServices((context,services) =>
                {
                    services.AddScoped<MainFRM>();
                    services.AddScoped<IFacadPattern,FacadPattern>();

                });
            return builder;
        }

    }
}
