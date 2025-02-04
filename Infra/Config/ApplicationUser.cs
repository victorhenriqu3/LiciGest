using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace Infra.Config;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}";

    [Key]
    [Required]
    [StringLength(11)]
    public string CPF { get; set; } = string.Empty;

    public UserRole Role { get; set; } = UserRole.Operador; // Valor padrão é Operador
}
