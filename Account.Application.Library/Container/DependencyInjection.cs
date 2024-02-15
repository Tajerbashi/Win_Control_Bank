using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Account.Application.Library.Container
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
