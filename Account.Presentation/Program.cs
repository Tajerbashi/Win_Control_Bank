using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.IDatabaseContext.AutoMapper;
using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.SEC;
using Account.Infrastructure.Library.ApplicationContext.GridDataConnection;
using Account.Infrastructure.Library.Patterns;
using Account.Presentation.Extentions;
using Account.Presentation.UserControls;
using AutoMapper;
using log4net;
using log4net.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Reflection;
namespace Presentation
{
    #region ConsoleTest

    //class Program
    //{
    //    private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    //    static void Main(string[] args)
    //    {
    //        var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
    //        XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
    //        Console.WriteLine("Hello World !");
    //        log.Info("Log Info");
    //        log.Debug("Log Debug");
    //        log.Error("Log Error");
    //        log.Warn("Log Warn");
    //        log.Fatal("Log Fatal");
    //        Console.ReadLine();
    //    }
    //}

    #endregion

    internal class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            var mapper = new MapperConfiguration(cfg => cfg.AddProfile(typeof(MapperProfiler)));
            //Application.Run(new MainFRM());


            #region IOC
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainFRM>();
                Application.Run(form1);
            }

            #endregion


        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                .AddDbContext<IContextDbApplication, ContextDbApplication>()
                .AddScoped<IExecuteDataTableQuery, ExecuteDataTableQuery>()
                .AddScoped(typeof(IContextDbApplication),typeof(ContextDbApplication))
                .AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork<ContextDbApplication>))
                .AddScoped(typeof(UnitOfWork<ContextDbApplication>))
                .AddScoped<IFacadPattern,FacadPattern>()
                .AddScoped<IBankRepository,BankRepository>()
                .AddScoped(typeof(LoggerProvider))
                .AddScoped(typeof(BankUC))
                .AddScoped<IUserRepository,UserRepository>()
                    ;
            services.AddScoped<MainFRM>();
        }
    }
}

