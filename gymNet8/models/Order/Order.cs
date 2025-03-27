using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gymNet8.models;

public class Order
{
    [Key] public long Id { get; set; }

    // Alterar de Customer para Client:
    [ForeignKey("Client")] public long ClientId { get; set; } // Note que o tipo deve ser igual ao Id do Client (long)

    // Alterar de Customer para Client:
    public Client Client { get; set; }


    public List<OrderItem> OrderItems { get; set; } = new();

    [Column(TypeName = "decimal(18,2)")] public decimal Total { get; set; }

    public OrderStatus Status { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    [StringLength(500)] public string? Notes { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public string? TrackingNumber { get; set; }
}