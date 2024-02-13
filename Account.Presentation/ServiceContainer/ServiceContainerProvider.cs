using Account.Application.Library.ApplicationContext.DapperService;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.SEC;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.ApplicationContext.GridDataConnection;
using Account.Infrastructure.Library.Patterns;
using Account.Presentation.Extentions;
using Account.Presentation.Forms;
using Account.Presentation.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace Account.Presentation.ServiceContainer
{
    public class ServiceContainerProvider
    {
        public static IServiceCollection FormInjector(IServiceCollection services)
        {
            services
                .AddScoped<IExecuteDataTableQuery, ExecuteDataTableQuery>()
                .AddScoped(typeof(CartNewForm))
                .AddScoped(typeof(CustomerNewForm))
                .AddScoped(typeof(CashMoneyNewForm))
                .AddScoped(typeof(TransactionNewForm))
                    ;
            return services;
        }
        public static IServiceCollection ServiceInjector(IServiceCollection services)
        {
            services
                .AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork<ContextDbApplication>))
                .AddScoped(typeof(UnitOfWork<ContextDbApplication>))
                .AddScoped<IDapperService, DapperServices>()
                .AddScoped<IBankRepository, BankRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<ICartRepository, CartRepository>()
                .AddScoped<IBlanceRepository, BlanceRepository>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped(typeof(LoggerProvider))
                ;
            return services;
        }
        public static IServiceCollection UserControlInjector(IServiceCollection services)
        {
            services
                .AddScoped(typeof(CalculateUC))
                .AddScoped(typeof(TransactionUC))
                .AddScoped(typeof(BankUC))
                .AddScoped(typeof(ReportUC))
                .AddScoped(typeof(CustomerUC))
                .AddScoped(typeof(SettingUC))
                .AddScoped(typeof(BlanceUC))
                .AddScoped(typeof(CartUC))
                .AddScoped(typeof(CashMoneyUC))
                ;
            return services;
        }
    }
}
