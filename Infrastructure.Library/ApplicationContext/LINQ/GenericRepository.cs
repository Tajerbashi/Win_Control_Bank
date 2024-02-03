namespace Infrastructure.Library.ApplicationContext.LINQ
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        public GenericRepository() { }

        public IEnumerator<T> EnumeratingOnList(IEnumerator<T> model)
        {
            while (model.MoveNext())
            {
                yield return model.Current;
            }
        }

        public ResultDTO<T> GetGot(Func<T> func)
        {
            var data = func();
            return new ResultDTO<T>(default)
            {
                Data = data,
            };
        }
        public T GetModel()
        {
            var data =  new ResultDTO<T>(default);
            return data.Data;
        }
    }
}
