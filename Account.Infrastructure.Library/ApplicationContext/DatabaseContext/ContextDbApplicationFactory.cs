using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Account.Infrastructure.Library.ApplicationContext.DatabaseContext
{
    public class ContextDbApplicationFactory : IDesignTimeDbContextFactory<ContextDbApplication>
    {
        public ContextDbApplication CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextDbApplication>();
            var defaultConnection =
            optionsBuilder.UseSqlServer(@"Data Source=TAJERBASHI;
                Initial Catalog=Accounting_Db; 
                User ID=sa; 
                Password=123123;
                TrustServerCertificate=True;");

            return new ContextDbApplication(optionsBuilder.Options);
        }

    }
}
