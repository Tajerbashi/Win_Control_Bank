
namespace Infrastructure.Library.ApplicationContext.LINQ
{
    public interface IGenericRepository<T>
    {
        IEnumerator<T> EnumeratingOnList(IEnumerator<T> model);
        ResultDTO<T> GetGot(Func<T> func);
        T GetModel();
    }
}