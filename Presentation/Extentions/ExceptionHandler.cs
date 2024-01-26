using System.Runtime.Serialization;

namespace Presentation.Extentions
{
    [Serializable]
    public class LogException : ApplicationException
    {
        private readonly LoggerProvider<LogException> loggerProvider;
        public LogException()
        {
            loggerProvider = new LoggerProvider<LogException>();
            loggerProvider.FatalLog(new Exception("نرم افزار به خطا مواجه شده است"));
        }

        public LogException(string message) : base(message)
        {
            loggerProvider = new LoggerProvider<LogException>();
            loggerProvider.ErrorLog(message);

        }

        public LogException(string message, Exception innerException) : base(message, innerException)
        {
            loggerProvider = new LoggerProvider<LogException>();
            loggerProvider.ErrorLog($"{message} - {innerException.Message}");

        }

        protected LogException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            loggerProvider = new LoggerProvider<LogException>();
            loggerProvider.ErrorLog($"{info} - {context.Context}");

        }
    }

}
