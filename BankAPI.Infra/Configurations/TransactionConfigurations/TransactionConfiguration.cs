using BankAPI.Domain.Models.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankAPI.Infra.Configurations.TransactionConfigurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ReferenceNumber).HasMaxLength(50);
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.Amount).IsRequired().HasColumnType("decimal(18,2)"); // Precisão decimal
            builder.Property(t => t.Description).IsRequired().HasMaxLength(255);
            builder.Property(t => t.Discriminator).IsRequired().HasMaxLength(50);
            builder.Property(t => t.TransactionFee).HasColumnType("decimal(18,2)"); // Precisão decimal, se aplicável
        }
    }

    public class DepositConfiguration : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            builder.HasBaseType<Transaction>();

            builder.Property(d => d.AccountId).IsRequired();
            builder.Property(d => d.DepositSlipImage).HasColumnType("varbinary(max)"); // Para imagens
            builder.Property(d => d.Notes).HasMaxLength(500);  // Limite para as notas
            builder.Property(d => d.Source).IsRequired().HasMaxLength(50);
            builder.Property(d => d.BankBranch).IsRequired().HasMaxLength(100);
            builder.Property(d => d.Status).IsRequired().HasConversion<int>(); // Conversão para int
            builder.Property(d => d.ClearingDate);
            builder.Property(d => d.IsReversal).IsRequired().HasDefaultValue(false); // Valor padrão
        }
    }
}
