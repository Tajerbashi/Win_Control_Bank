using Account.Applicatino.Library.IDatabaseContext.DatabaseContext;
using Account.Application.Library.ApplicationContext.Configurations;
using Account.Application.Library.ApplicationContext.Sql_Queries.Views.C_;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Entities.CNT;
using Account.Domain.Library.Entities.LOG;
using Account.Domain.Library.Entities.RPT;
using Account.Domain.Library.Entities.SEC;
using Account.Domain.Library.Entities.WEB;
using Microsoft.EntityFrameworkCore;

namespace Account.Application.Library.ApplicationContext.DatabaseContext
{

    public class ContextDbApplication : DbContext, IContextDbApplication
    {
        public ContextDbApplication(DbContextOptions<ContextDbApplication> option) : base(option)
        {
        }
        public ContextDbApplication()
        {
        }


        #region BUS
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Blance> Blances { get; set; }
        #endregion

        #region CNT
        public DbSet<ConstVariable> ConstVariables { get; set; }
        #endregion

        #region LOG
        public DbSet<NLog> NLogs { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        #endregion

        #region RPT
        public DbSet<BankReport> BankReports { get; set; }
        public DbSet<CartReport> CartReports { get; set; }
        public DbSet<CustomerReport> CustomerReports { get; set; }
        #endregion

        #region SEC
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        #endregion

        #region WEB
        public DbSet<WebService> WebServices { get; set; }
        #endregion

        #region ViewBUS
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=RHG-DATABASE\DEV;Initial Catalog=Accounting_Db; User ID=sa; Password=soft157703ware;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer("Data Source=TAJERBASHI;Initial Catalog=Accounting_Db; User ID=sa; Password=123123;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ViewConfiguration.BUS_View(modelBuilder);

            modelBuilder.ApplyConfiguration(new BankConfiguration());
            modelBuilder.ApplyConfiguration(new BlanceConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ConstVariableConfiguration());
            modelBuilder.ApplyConfiguration(new WebServiceConfiguration());
        }

    }
}
