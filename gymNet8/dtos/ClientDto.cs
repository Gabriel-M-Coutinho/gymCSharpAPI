using System.ComponentModel.DataAnnotations;

namespace gymNet8.dtos;

public class ClientDto
{
    public long Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "E-mail inválido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é obrigatório.")]
    [Phone(ErrorMessage = "Telefone inválido.")]
    public string Telephone { get; set; } = string.Empty;
}