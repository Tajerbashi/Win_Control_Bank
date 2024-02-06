using Infrastructure.Library.Exceptions;

namespace Presentation.Extentions
{
    public class ExceptionHandler<T> : InvalidModelException<T>
    {
        private readonly LoggerProvider<ExceptionHandler> logger = new LoggerProvider<ExceptionHandler>();
        public ExceptionHandler(string message, T data) : base(message, data)
        {
            logger.Logger(Microsoft.Extensions.Logging.LogLevel.Warning,new Exception(message));
        }
    }
}
