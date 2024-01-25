using AutoMapper;
using Infrastructure.Library.ApplicationContext.AutoMapper;
using Infrastructure.Library.Models.DTOs.LOG;
using Microsoft.Extensions.Logging;
using Presentation.Extentions;
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
            ILoggerFactory loggerFactory = LoggerFactory.Create(
                builder =>
                    builder.SetMinimumLevel(LogLevel.Trace));
            ILogger logger = loggerFactory.CreateLogger(typeof(Program));
            logger.LogInformation("Hello World ! {description}", "fun");
            MapperConfiguration mapper = new MapperConfiguration(cfg => cfg.AddProfile(typeof(MapperProfiler)));
            ApplicationConfiguration.Initialize();
            Application.Run(new MainFRM(new Logger<SystemLogDTO>(new LoggerFactory())));
        }


    }
}