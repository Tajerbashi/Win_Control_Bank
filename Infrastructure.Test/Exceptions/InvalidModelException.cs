namespace Infrastructure.Test.Exceptions
{
    public class InvalidModelException : Exception
    {
        public int Type { get; private set; }
        public InvalidModelException(string message, int type) : base(message)
        {
            Type = type;
        }
    }
}
