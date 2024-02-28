using Account.Application.Library.Container;
using Account.Application.Library.IDatabaseContext.AutoMapper;
using Account.Infrastructure.Library.Container;
using Account.Presentation.ServiceContainer;
using AutoMapper;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        private static IConfiguration Configuration { get; }
        public static ILoggerRepository loggerRepository { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            loggerRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(loggerRepository, new FileInfo("log4net.config"));
            var mapper = new MapperConfiguration(cfg => cfg.AddProfile(typeof(MapperProfiler)));
            #region Configuration / IOC
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainFRM>();
                Application.Run(form1);
            }

            #endregion

        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure(Configuration);
            services.AddDbContext(Configuration);
            services.ServiceInjector();
            services.UserControlInjector();
            services.UserFluentValidation();
            services.FormInjector();
        }
    }
}

