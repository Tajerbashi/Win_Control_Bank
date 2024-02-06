using Infrastructure.Library.ApplicationContext.DatabaseContext;

namespace Infrastructure.Library.ApplicationContext.LINQ
{
    public class LinqGenerator
    {
        private readonly ContextDbApplication contextDbApplication = new ContextDbApplication();
        private readonly GenericRepository<DatabaseContext> genericRepository = new GenericRepository<DatabaseContext>();
        public LinqGenerator()
        {

        }
        public void ShowData()
        {
            genericRepository.GetGot(genericRepository.GetModel);
        }
        public void UpdateData()
        {
        }
    }
}
