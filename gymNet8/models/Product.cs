using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gymNet8.models;

public class Product
{
    // Construtor padrão necessário para Entity Framework
    public Product()
    {
    }

    public Product(string name, string description, string category, int quantity, decimal price, string categoryName,
        string image)
    {
        Name = name;
        Description = description;
        Category = category;
        Quantity = quantity;
        Price = price;
        CategoryName = categoryName;
        Image = image;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required] [StringLength(100)] public string Name { get; set; }

    [StringLength(500)] public string Description { get; set; }

    [Required] [StringLength(50)] public string Category { get; set; }

    [Range(0, int.MaxValue)] public int Quantity { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    [Range(0, double.MaxValue)]
    public decimal Price { get; set; }

    [StringLength(100)] public string CategoryName { get; set; }

    [StringLength(500)] public string Image { get; set; }

    // Relacionamentos
    public List<OrderItem> OrderItems { get; set; } = new();
}