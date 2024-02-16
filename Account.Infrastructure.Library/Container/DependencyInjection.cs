using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.CNT;
using Account.Application.Library.Repositories.SEC;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.AppSetting;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.BUS;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Account.Infrastructure.Library.Container
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ContextDbApplication>(options =>
               options.UseSqlServer(AppSettingConfiguration.ConnectionString()));

            services
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<IBankRepository, BankRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<ICartRepository, CartRepository>()
                .AddScoped<IBlanceRepository, BlanceRepository>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<IConstVariableRepository, ConstVariableRepository>()
                ;


            return services;
        }
    }
}
