using Domain.Library.Entities.BUS;
using Domain.Library.Entities.CNT;
using Domain.Library.Entities.WEB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Library.ApplicationContext.Configurations
{
    #region BUS
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.HasIndex(x => x.BankName).IsUnique();

            builder.HasMany(x => x.Carts)
                .WithOne(x => x.Bank)
                .HasForeignKey(x => x.BankID)
                .IsRequired();

            builder.HasMany(x => x.BankReports)
                .WithOne(x => x.Bank)
                .HasForeignKey(x => x.BankID)
                .IsRequired();
        }
    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasIndex(x => new
            {
                x.FullName,
                x.Title,
            }).IsUnique();
            builder.HasMany(x => x.Carts)
                .WithOne(x => x.Customer);
        }
    }

    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasIndex(x => new
            {
                x.BankID,
                x.AccountNumber,
            }).IsUnique();

            builder.HasOne(x => x.Bank)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.BankID)
                .IsRequired();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.CustomerID)
                .IsRequired();

            builder.HasMany(x => x.CartHistories)
                .WithOne(y => y.Cart)
                .HasForeignKey(f => f.CartID);

            builder.HasMany(x => x.Blances)
                .WithOne(y => y.Cart)
                .HasForeignKey(z => z.CartID);
        }
    }
    public class BlanceConfiguration : IEntityTypeConfiguration<Blance>
    {
        public void Configure(EntityTypeBuilder<Blance> builder)
        {
            builder.HasMany(x => x.BlanceLogs)
                .WithOne(x => x.Blance)
                .HasForeignKey(x => x.BlanceID)
                .IsRequired();

            builder.HasOne(x => x.Cart)
                .WithMany(y => y.Blances)
                .HasForeignKey(z => z.CartID);

            builder.HasMany(x => x.CartHistories)
                .WithOne(y => y.Blance)
                .HasForeignKey(f => f.BlanceID);

        }
    }



    public class CartHistoryConfiguration : IEntityTypeConfiguration<CartHistory>
    {
        public void Configure(EntityTypeBuilder<CartHistory> builder)
        {
            builder.HasOne(x => x.Cart)
                .WithMany(x => x.CartHistories)
                .HasForeignKey(x => x.CartID)
                .OnDelete(DeleteBehavior.NoAction);

          
            builder.HasOne(x => x.Blance)
               .WithMany(x => x.CartHistories)
               .HasForeignKey(x => x.BlanceID)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }



  
    #endregion

    #region SEC
    #endregion

    #region LOG
    #endregion

    #region RPT
    #endregion

    #region WEB
    public class WebServiceConfiguration : IEntityTypeConfiguration<WebService>
    {
        public void Configure(EntityTypeBuilder<WebService> builder)
        {
        }
    }
    #endregion

    #region CNT
    public class ConstVariableConfiguration : IEntityTypeConfiguration<ConstVariable>
    {
        public void Configure(EntityTypeBuilder<ConstVariable> builder)
        {
        }
    }
    #endregion

}
