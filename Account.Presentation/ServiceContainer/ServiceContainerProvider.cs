using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.SEC;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Presentation.Extentions;
using Account.Presentation.Forms;
using Account.Presentation.UserControls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presentation;
using System.ComponentModel;

namespace Account.Presentation.ServiceContainer
{
    public static class ServiceContainerProvider
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var ct= AppSettings.ConnectionStrings(services);
            services.AddDbContext<IContextDbApplication, ContextDbApplication>(config =>
                config.UseSqlServer(ct.DefaultConnection), ServiceLifetime.Scoped);
        }
        public static void FormInjector(this IServiceCollection services)
        {
            services
                .AddScoped(typeof(MainFRM))
                .AddScoped(typeof(CartNewForm))
                .AddScoped(typeof(CustomerNewForm))
                .AddScoped(typeof(CashMoneyNewForm))
                .AddScoped(typeof(TransactionNewForm))
                    ;
        }
        public static void ServiceInjector(this IServiceCollection services)
        {

            services
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<IBankRepository, BankRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<ICartRepository, CartRepository>()
                .AddScoped<IBlanceRepository, BlanceRepository>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped(typeof(LoggerProvider))
                ;
        }
        public static void UserControlInjector(this IServiceCollection services)
        {
            services
                .AddTransient(typeof(LoggerProvider))
                .AddSingleton(typeof(CalculateUC))
                .AddSingleton(typeof(TransactionUC))
                .AddSingleton(typeof(BankUC))
                .AddSingleton(typeof(ReportUC))
                .AddSingleton(typeof(CustomerUC))
                .AddSingleton(typeof(SettingUC))
                .AddSingleton(typeof(BlanceUC))
                .AddSingleton(typeof(CartUC))
                .AddSingleton(typeof(CashMoneyUC))
                ;
        }
       
    }
}
