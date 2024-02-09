using Infrastructure.Library.Exceptions;

namespace Presentation.Extentions
{
    public class ExceptionHandler<T> : InvalidModelException<T>
    {
        public ExceptionHandler(string message, T data) : base(message, data)
        {
        }
    }
}
