using AutoMapper;
using Infrastructure.Library.ApplicationContext.AutoMapper;
using Infrastructure.Library.Models.DTOs.LOG;
using Microsoft.Extensions.Logging;
namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MapperConfiguration mapper = new MapperConfiguration(cfg => cfg.AddProfile(typeof(MapperProfiler)));
            ApplicationConfiguration.Initialize();
            Application.Run(new MainFRM(new Logger<SystemLogDTO>(new LoggerFactory())));
        }
    }
}