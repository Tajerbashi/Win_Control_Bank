using Domain.Library.Entities.BUS;
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

    public class BlanceConfiguration : IEntityTypeConfiguration<Blance>
    {
        public void Configure(EntityTypeBuilder<Blance> builder)
        {
            builder.HasOne(x => x.Transaction)
                .WithOne(x => x.Blance)
                .HasForeignKey<Blance>(x => x.TransactionID)
                .IsRequired();

            //  TODO Many To ONE
            builder.HasMany(x => x.BlanceLogs)
                .WithOne(x => x.Blance)
                .HasForeignKey(x => x.BlanceID)
                .IsRequired();
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
            
            //  TODO Many To ONE
        }
    }

    public class CartHistoryConfiguration : IEntityTypeConfiguration<CartHistory>
    {
        public void Configure(EntityTypeBuilder<CartHistory> builder)
        {
            builder.HasOne(x => x.Cart)
                .WithMany(x => x.CartHistories)
                .HasForeignKey(x => x.CartID);
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

    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(x => x.Blance)
                .WithOne(x => x.Transaction)
                .HasForeignKey<Blance>(x => x.TransactionID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Cart)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.CartID) 
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class BlanceCustomerConfiguration : IEntityTypeConfiguration<BlanceCustomer>
    {
        public void Configure(EntityTypeBuilder<BlanceCustomer> builder)
        {
            builder.HasOne(x => x.Blance)
                .WithMany(x => x.BlanceCustomers)
                .HasForeignKey(x => x.BlanceID);
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
