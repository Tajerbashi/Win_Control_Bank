using Account.Application.Library.IDatabaseContext.AutoMapper;
using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Presentation.ServiceContainer;
using AutoMapper;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        public static IConfiguration Configuration;
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
#else
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
#endif

            Configuration = builder.Build();

            var config = new ConfigurationBuilder()
                .SetBasePath(LocalPath())
                .AddJsonFile("appsettings.json").Build();

            var formatSettings = config.GetChildren().Where(x => x.Key == "ConnectionStrings" ).Select(x => new ConnectionStrings
            {
                DefaultConnection = x.GetSection("DefaultConnection").Value
            }).Single().DefaultConnection;

            services.AddLogging(configure => configure.AddConsole());

            services.AddDbContext<IContextDbApplication, ContextDbApplication>(options =>
                //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")),
                options.UseSqlServer(formatSettings),
                ServiceLifetime.Transient);

            ServiceContainerProvider.ServiceInjector(services);
            ServiceContainerProvider.UserControlInjector(services);
            ServiceContainerProvider.FormInjector(services);

            services.AddScoped<MainFRM>();
        }


        public static string LocalPath()
        {
            string address = "";
            // محل که نرم افزار از آنجا اجرا میشود در متغییر ذخیره میکند
            var pp = Path.GetDirectoryName(Application.ExecutablePath).Split("\\");
            for (int i = 0; i < pp.Length - 3; i++)
            {
                address += ($"{pp[i]}\\");
            }
            return ($"{address}");

        }


    }
}

