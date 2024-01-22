

using AutoMapper;
using Infrastructure.Library.ApplicationContext.AutoMapper;
using static Dapper.SqlMapper;
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

            MapperConfiguration mapper = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile(typeof(MapperProfiler));
                cfg.AddProfile(typeof(MapperProfiler));
            });
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainFRM());
        }
    }
}