using Microsoft.EntityFrameworkCore;
using Photogram.Domain.Entities;

namespace Photogram.Persistence.DataContext;

public class AppDbContext : DbContext
{
    //public DbSet<User> Users => Set<User>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
    }
}