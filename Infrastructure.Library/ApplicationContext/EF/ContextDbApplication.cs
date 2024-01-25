using Domain.Library.Entities.BUS;
using Domain.Library.Entities.CNT;
using Domain.Library.Entities.HSR;
using Domain.Library.Entities.LOG;
using Domain.Library.Entities.RPT;
using Domain.Library.Entities.SEC;
using Domain.Library.Entities.WEB;
using Infrastructure.Library.ApplicationContext.Configurations;
using Infrastructure.Library.ApplicationContext.Sql_Queries.Views.C_;
using Infrastructure.Library.Models.Views.BUS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure.Library.ApplicationContext.EF
{
    public interface IContextDbApplication : IDisposable
    {
        //IDbContextTransaction BeginTransaction();
        //void CommitTransaction();
        //void RollBackTransaction();
    }
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

        #region SEC
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        #endregion

        #region LOG
        public DbSet<ApplicationLog> ApplicationLogs { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        public DbSet<SecurityLog> SecurityLogs { get; set; }
        public DbSet<SetupLog> SetupLogs { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        #endregion

        #region HSR
        public DbSet<CartHistory> CartHistories { get; set; }

        #endregion

        #region RPT
        public DbSet<BankReport> BankReports { get; set; }
        public DbSet<CartReport> CartReports { get; set; }
        public DbSet<CustomerReport> CustomerReports { get; set; }
        #endregion

        #region CNT
        public DbSet<ConstVariable> ConstVariables { get; set; }

        #endregion

        #region WEB
        public DbSet<WebService> WebServices { get; set; }

        #endregion



        #region ViewBUS
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Data Source=RHG-DATABASE\DEV;Initial Catalog=Accounting_Db; User ID=sa; Password=soft157703ware;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Data Source=TAJERBASHI;Initial Catalog=Accounting_Db; User ID=sa; Password=123123;TrustServerCertificate=True;");
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

        //public IDbContextTransaction BeginTransaction()
        //{
        //    return base.Database.BeginTransaction();
        //}

        //public void CommitTransaction()
        //{
        //    base.Database.CommitTransaction();
        //}

        //public void RollBackTransaction()
        //{
        //    base.Database.RollbackTransaction();
        //}
    }
}
