using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gymNet8.models;

public class Order
{
    [Key] public int Id { get; set; }

    // Chave estrangeira para o Cliente
    [ForeignKey("Customer")] public long CustomerId { get; set; }

    // Navegação para o Cliente
    public Client Customer { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();

    [Column(TypeName = "decimal(18,2)")] public decimal Total { get; set; }

    public OrderStatus Status { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    [StringLength(500)] public string? Notes { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public string? TrackingNumber { get; set; }
}