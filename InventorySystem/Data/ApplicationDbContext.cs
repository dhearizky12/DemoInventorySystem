namespace InventorySystem.Data;
using InventorySystem.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<Item> Item { get; set; } = default!;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    { //membuat fluentApi rule database User
        base.OnModelCreating(builder);
        builder.Entity<User>()
        .Property(e => e.FristName)
        .HasMaxLength(200);

        builder.Entity<User>()
        .Property(e => e.LastName)
        .HasMaxLength(200);

        builder.Entity<User>()
        .Property(e => e.CodeEmployee)
        .HasMaxLength(10);
    }
}
