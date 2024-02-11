using log4net;

namespace Account.Presentation.Extentions
{
    public class LoggerProvider
    {
        public ILog Log;
        public LoggerProvider()
        {
            log4net.Config.XmlConfigurator.Configure();
            Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}
