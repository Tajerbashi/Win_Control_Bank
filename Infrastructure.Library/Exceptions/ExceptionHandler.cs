using Newtonsoft.Json;

namespace Infrastructure.Library.Exceptions
{
    public class ExceptionHandler
    {
    }
    public class InvalidModelException<T> : Exception
    {
        public T InvalidData { get; private set; }
        public string ModelName { get; private set; }
        public string JsonModel { get; private set; }
        public InvalidModelException(string message, T data) 
            : base(message)
        {
            ModelName = typeof(T).Name.Replace("DTO","");
            InvalidData = data;
            JsonModel = JsonConvert.SerializeObject(data);
        }
    }
}
