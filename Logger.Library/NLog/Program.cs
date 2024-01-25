//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

//namespace Logger.Library.NLog
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
//            try
//            {
//                logger.Debug("Init main");
//                CreateWebHostBuilder(args).Build().Run();
//            }
//            catch (Exception e)
//            {
//                logger.Error(e, "Program stopped because of an exception.");
//                throw;
//            }
//            finally
//            {
//                LogManager.Shutdown();
//            }
//        }

//        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//            WebHost.CreateDefaultBuilder(args)
//                .UseStartup<Startup>()
//                .ConfigureLogging(builder =>
//                {
//                    builder.ClearProviders();
//                    builder.SetMinimumLevel(LogLevel.Trace);
//                }).UseNLog();
//    }
//}
