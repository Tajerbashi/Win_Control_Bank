using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.SEC;
using Account.Application.Library.Validation.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.BUS;
using Account.Presentation.Extentions;
using Account.Presentation.Forms;
using Account.Presentation.UserControls;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presentation;
using System;
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
                .AddScoped(typeof(BankNewForm))
                .AddScoped(typeof(CartNewForm))
                .AddScoped(typeof(CustomerNewForm))
                .AddScoped(typeof(TransactionNewForm))
                .AddScoped(typeof(CashableBlanceForm))
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
        public static void UserFluentValidation(this IServiceCollection services)
        {
            services.AddScoped<IValidator<BankDTO>, BankValidation>();
            services.AddScoped<IValidator<CustomerDTO>, CustomerValidation>();
            services.AddScoped<IValidator<CartDTO>, CartValidation>();
            services.AddScoped<IValidator<BlanceDTO>, BlanceValidation>();
        }
        public static void UserControlInjector(this IServiceCollection services)
        {
            services
                .AddTransient(typeof(LoggerProvider))
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
        }
       
    }
}
