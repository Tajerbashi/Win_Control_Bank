using Domain.Library.Entities.BUS;
using Domain.Library.Entities.LOG;
using Domain.Library.Entities.RPT;
using Domain.Library.Entities.SEC;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.ApplicationContext.EF
{
    public class ContextDbApplication : DbContext
    {
        public ContextDbApplication(DbContextOptions<ContextDbApplication> option) : base(option)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<TransferReport> TransferReports { get; set; }
        public DbSet<TransactionReport> TransactionReports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=172.20.1.20\\DEV;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=soft157703ware;");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=TAJERBASHI;Initial Catalog=Accounting_Db; User ID=sa; Password=123123;");
        }
    }
}
