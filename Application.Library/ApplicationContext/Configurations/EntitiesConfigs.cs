using Domain.Library.Entities.BUS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Library.ApplicationContext.Configurations
{
    #region BUS
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasMany(x => x.CartTransactions)
                .WithOne(x => x.Transaction)
                .HasForeignKey(x => x.TransactionID);
        }
    }
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(B => B.Bank)
                 .WithMany(C => C.Carts)
                 .HasForeignKey(f => f.BankID);

            builder.HasOne(C => C.Customer)
                .WithMany(C => C.Carts)
                .HasForeignKey(f => f.CustomerID);

            builder.HasMany(x => x.CartTransactions)
               .WithOne(x => x.Cart)
               .HasForeignKey(x => x.CartID);

            builder.HasMany(x => x.Blances)
                .WithOne(x => x.Cart)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    public class BlanceConfiguration : IEntityTypeConfiguration<Blance>
    {
        public void Configure(EntityTypeBuilder<Blance> builder)
        {
            builder.HasOne(x => x.Cart)
                .WithMany(x => x.Blances)
                .HasForeignKey(x => x.CartID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    public class CartHistoryConfiguration : IEntityTypeConfiguration<CartHistory>
    {
        public void Configure(EntityTypeBuilder<CartHistory> builder)
        {
            builder.HasOne(B => B.Cart)
                 .WithMany(C => C.CartHistories)
                 .HasForeignKey(f => f.ID);
        }
    }

    #endregion
    #region SEC
    #endregion
    #region LOG
    #endregion
    #region RPT
    #endregion
}
