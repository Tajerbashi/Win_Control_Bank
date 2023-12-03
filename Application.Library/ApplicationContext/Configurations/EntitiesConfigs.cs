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
        }
    }
    public class BlanceConfiguration : IEntityTypeConfiguration<Blance>
    {
        public void Configure(EntityTypeBuilder<Blance> builder)
        {
            builder.HasOne(B => B.Cart)
                 .WithMany(C => C.Blances)
                 .HasForeignKey(f => f.ID);
        }
    }
    public class CartHitoryConfiguration : IEntityTypeConfiguration<CartHitory>
    {
        public void Configure(EntityTypeBuilder<CartHitory> builder)
        {
            builder.HasOne(B => B.Cart)
                 .WithMany(C => C.CartHitories)
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
