using Account.Application.Library.ApplicationContext.Configurations;
using Account.Application.Library.ApplicationContext.Sql_Queries.Views.C_;
using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Entities.CNT;
using Account.Domain.Library.Entities.LOG;
using Account.Domain.Library.Entities.RPT;
using Account.Domain.Library.Entities.SEC;
using Account.Domain.Library.Entities.WEB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;

namespace Account.Infrastructure.Library.ApplicationContext.DatabaseContext
{
    public class ContextDbApplication : DbContext, IContextDbApplication
    {
        private SqlConnection _con;
        public ContextDbApplication(DbContextOptions<ContextDbApplication> option) : base(option)
        {

        }

        public ContextDbApplication()
        {
        }


        #region BUS
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<Bank> Banks => Set<Bank>();
        public DbSet<Blance> Blances => Set<Blance>();
        #endregion

        #region CNT
        public DbSet<ConstVariable> ConstVariables => Set<ConstVariable>();
        #endregion

        #region LOG
        public DbSet<NLog> NLogs => Set<NLog>();
        public DbSet<EventLog> EventLogs => Set<EventLog>();
        #endregion

        #region RPT
        public DbSet<BankReport> BankReports => Set<BankReport>();
        public DbSet<CartReport> CartReports => Set<CartReport>();
        public DbSet<CustomerReport> CustomerReports => Set<CustomerReport>();
        #endregion

        #region SEC
        public DbSet<User> Users => Set<User>();
        public DbSet<UserRole> UserRoles => Set<UserRole>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Group> Groups => Set<Group>();
        public DbSet<GroupUser> GroupUsers => Set<GroupUser>();
        #endregion

        #region WEB
        public DbSet<WebService> WebServices => Set<WebService>();
        #endregion

        #region ViewBUS
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            ViewConfiguration.BUS_View(modelBuilder);

            modelBuilder.ApplyConfiguration(new BankConfiguration());
            modelBuilder.ApplyConfiguration(new BlanceConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ConstVariableConfiguration());
            modelBuilder.ApplyConfiguration(new WebServiceConfiguration());
        }

        public DataTable GetDataTable(string query)
        {
            var defaultConnectinoString = AppSettingConfiguration.ConnectionString();
            _con = new SqlConnection(defaultConnectinoString);
            string cmd = query;
            var sqladapter = new SqlDataAdapter(cmd, _con);
            var commondbuilder = new SqlCommandBuilder(sqladapter);
            var result = new DataSet();
            sqladapter.Fill(result);
            //_con.Close();
            //_con.Dispose();
            return result.Tables[0];
        }

    }

}


