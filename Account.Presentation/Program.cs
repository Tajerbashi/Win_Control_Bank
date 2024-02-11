using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.IDatabaseContext.AutoMapper;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
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
            ApplicationConfiguration.Initialize();

            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            var mapper = new MapperConfiguration(cfg => cfg.AddProfile(typeof(MapperProfiler)));


            //var builder = ConfigureServices();
            //var host =builder.Build();

            //using (var serviceScope = host.Services.CreateScope())
            //{
            //    var service = serviceScope.ServiceProvider;
            //    try
            //    {
            //        var form = service.GetRequiredService<MainFRM>();
            //        Application.Run(form);
            //        Console.WriteLine("Success Run");
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Error Run");
            //    }
            //}

            Application.Run(new MainFRM());
        }
        //private static IHostBuilder ConfigureServices()
        //{
        //    var builder = new HostBuilder()
        //     .ConfigureServices((hostContext, services) =>
        //     {
        //         services.AddSingleton<MainFRM>();
        //         services.AddLogging(configure => configure.AddConsole());
        //         services.AddScoped<IFacadPattern, FacadPattern>();
        //         //services.AddScoped<IUnitOfWork, UnitOfWork<ContextDbApplication>>()
        //         ;

        //     });
        //    return builder;
        //}
    }
}

