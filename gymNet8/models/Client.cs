using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gymNet8.models;

public class Client
{
    // Construtor padrão necessário para Entity Framework
    public Client()
    {
    }

    public Client(string name, string email, string telephone)
    {
        Name = name;
        Email = email;
        Telephone = telephone;
        CreatedAt = DateTime.UtcNow;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required] [StringLength(100)] public string Name { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; }

    [Phone] [StringLength(20)] public string Telephone { get; set; }

    [Required] public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    // Relacionamento com pedidos
    public List<Order> Orders { get; set; } = new();

    // Método para atualizar o cliente
    public void Update(string name, string email, string telephone)
    {
        Name = name;
        Email = email;
        Telephone = telephone;
        UpdatedAt = DateTime.UtcNow;
    }
}