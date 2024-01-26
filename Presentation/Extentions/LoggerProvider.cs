using log4net;
using log4net.Config;
using System.Reflection;

namespace Presentation.Extentions
{
    public class LoggerProvider<T>
        where T : class
    {

        private readonly ILog log;
        public LoggerProvider()
        {
            //log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log = LogManager.GetLogger(typeof(T));
        }
        public void DebugLog(string msg)
        {
            log.Debug(msg);
        }
        public void FatalLog(string msg)
        {
            log.Fatal(msg);
        }
        public void InfoLog(string msg)
        {
            log.Info(msg);
        }
        public void ErrorLog(string msg)
        {
            log.Error(msg);
        }
        public void WarnLog(string msg)
        {
            log.Warn(msg);
        }


    }
}
