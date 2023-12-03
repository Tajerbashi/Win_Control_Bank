using Domain.Library.Entities.BUS;
using Domain.Library.Entities.LOG;
using Domain.Library.Entities.RPT;
using Domain.Library.Entities.SEC;
using Infrastructure.Library.ApplicationContext.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.ApplicationContext.EF
{
    public class ContextDbApplication : DbContext
    {
        public ContextDbApplication(DbContextOptions<ContextDbApplication> option) : base(option)
        {
        }
        public ContextDbApplication()
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<UserRoleGroup> UserRoleGroups { get; set; }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartHitory> CartHitories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<CartTransaction> CartTransactions { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Blance> Blances { get; set; }


        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<CartLog> CartLogs { get; set; }
        public DbSet<BlanceLog> BlanceLogs { get; set; }
        public DbSet<TransactionLog> TransactionLogs { get; set; }


        public DbSet<BankReport> BankReports { get; set; }
        public DbSet<CartReport> CartReports { get; set; }
        public DbSet<TransactionReport> TransactionReports { get; set; }
        public DbSet<TransferReport> TransferReports { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=172.20.1.20\\DEV;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=soft157703ware;");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=TAJERBASHI;Initial Catalog=Accounting_Db; User ID=sa; Password=123123;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new BlanceConfiguration());
            modelBuilder.ApplyConfiguration(new CartHitoryConfiguration());
        }
        

    }
}
