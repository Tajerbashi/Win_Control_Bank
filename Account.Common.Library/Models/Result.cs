namespace Account.Common.Library.Models
{
    public class Result<T> where T : class
    {
        public T Data { get; set; }
    }
}
