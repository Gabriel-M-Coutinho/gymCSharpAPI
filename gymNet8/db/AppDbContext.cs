using gymNet8.models;
using Microsoft.EntityFrameworkCore;

namespace gymNet8.db;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurações de índice
        modelBuilder.Entity<Product>()
            .HasIndex(p => p.Name);

        modelBuilder.Entity<Client>()
            .HasIndex(c => c.Email)
            .IsUnique();

        // RELACIONAMENTO CORRIGIDO: Order -> Client
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Client) // Propriedade de navegação (Client)
            .WithMany(c => c.Orders) // Coleção em Client
            .HasForeignKey(o => o.ClientId) // FK correta (ClientId)
            .OnDelete(DeleteBehavior.Restrict); // Opcional: define comportamento de deleção

        // Relacionamentos de OrderItem
        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Product)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(oi => oi.ProductId);
    }
}