using Account.Infrastructure.Library.Models.Views.BUS;
using Microsoft.EntityFrameworkCore;

namespace Account.Infrastructure.Library.ApplicationContext.Sql_Queries.Views.C_
{
    public class ViewConfiguration
    {
        public static void BUS_View(ModelBuilder builder)
        {
            //builder.Entity<CartHistoryView>(cfg =>
            //{
            //    cfg.HasNoKey();
            //    cfg.ToView("History");
            //});
        }
    }
}
