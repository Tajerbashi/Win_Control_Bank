using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Account.Infrastructure.Library.ApplicationContext.DatabaseContext
{
    public class ContextDbApplicationFactory : IDesignTimeDbContextFactory<ContextDbApplication>
    {
        public ContextDbApplication CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextDbApplication>();
            var defaultConnection = AppSettingConfiguration.ConnectionString();
            optionsBuilder.UseSqlServer(defaultConnection);
            return new ContextDbApplication(optionsBuilder.Options);
        }
    }
}


