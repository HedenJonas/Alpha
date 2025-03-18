using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class LoginFormModel
{
    [Display(Name = "Email", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "You must enter your email address.")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "You must enter your Password.")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public bool RemeberMe { get; set; }
}