using AutoMapper;
using log4net;
using log4net.Config;
using Account.Presentation.Extentions;
using System.Reflection;
using Account.Applicatino.Library.IDatabaseContext.AutoMapper;
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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            MapperConfiguration mapper = new MapperConfiguration(cfg => cfg.AddProfile(typeof(MapperProfiler)));
            ApplicationConfiguration.Initialize();
            Application.Run(new MainFRM());
        }
    }
}