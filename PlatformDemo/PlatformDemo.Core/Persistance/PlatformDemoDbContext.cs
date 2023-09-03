using Microsoft.EntityFrameworkCore;
using PlatformDemo.Core.Configuration;
using PlatformDemo.Core.Configuration.Seed;
using PlatformDemo.Core.Model;

namespace PlatformDemo.Core;

public class PlatformDemoDbContext: DbContext
{
    public PlatformDemoDbContext(DbContextOptions<PlatformDemoDbContext> options) : base(options)
    {
    }
    
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CustomerConfiguration());
        builder.ApplyConfiguration(new OrderConfiguration());
        DefaultDataSeed.Seed(builder);
        base.OnModelCreating(builder);
    }
}