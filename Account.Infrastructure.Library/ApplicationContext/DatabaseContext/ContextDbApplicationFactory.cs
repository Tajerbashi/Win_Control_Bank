using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Account.Infrastructure.Library.ApplicationContext.DatabaseContext
{
    public class ContextDbApplicationFactory : IDesignTimeDbContextFactory<ContextDbApplication>
    {
        //public ContextDbApplication CreateDbContext(string[] args)
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<ContextDbApplication>();
        //    var defaultConnection =
        //    optionsBuilder.UseSqlServer(@"Data Source=TAJERBASHI;
        //        Initial Catalog=Accounting_Db; 
        //        User ID=sa; 
        //        Password=123123;
        //        TrustServerCertificate=True;");

        //    return new ContextDbApplication(optionsBuilder.Options);
        //}

        //public ContextDbApplication CreateDbContext(string[] args)
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<ContextDbApplication>();
        //    var basePath = Directory.GetCurrentDirectory();
        //    var configuration = new ConfigurationBuilder()
        //                        .SetBasePath(basePath)
        //                        .AddJsonFile("appsettings.json", reloadOnChange: true, optional: false)
        //                        .Build();

        //    var defaultConnection = configuration.GetConnectionString("DefaultConnection");

        //    optionsBuilder.UseSqlServer(defaultConnection);

        //    return new ContextDbApplication(optionsBuilder.Options);
        //}
        public ContextDbApplication CreateDbContext(string[] args)
        {
        }
    }
}
