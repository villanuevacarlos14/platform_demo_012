using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatformDemo.Core.Model;

namespace PlatformDemo.Core.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.OrderNumber)
            .ValueGeneratedOnAdd();;
        builder.Property(x => x.Amount)
            .HasColumnType("decimal(18,2)");;
        
        builder.HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId);
    }
}