using System.ComponentModel.DataAnnotations;
namespace Hinamori.ViewModels;

public class LoginViewModel
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string? EmailValidation { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string? PasswordValidation { get; set; }
}