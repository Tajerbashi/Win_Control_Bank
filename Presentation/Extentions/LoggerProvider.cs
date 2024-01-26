using log4net;

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
        public void FatalLog(Exception ex)
        {
            log.Fatal(ex.Message);
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

        public void ExceptionLog(Exception ex)
        {
            log.Error("این یک خطا است");
            log.Info("این یک انفو است");
            log.Fatal("این یک فتال است");
            log.Debug("این یک رفع است");
            log.Warn("این یک هشدار است");
        }
    }
}
