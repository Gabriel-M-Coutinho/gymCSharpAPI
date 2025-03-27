using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gymNet8.models;

public class OrderItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [ForeignKey("Client")] public long OrderId { get; set; } // Tipo igual ao Order.Id

    [ForeignKey("Product")] public long ProductId { get; set; } // Tipo igual ao Product.Id

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18,2)")] public decimal UnitPrice { get; set; }

    // Navegação
    public Order Order { get; set; }
    public Product Product { get; set; }
}