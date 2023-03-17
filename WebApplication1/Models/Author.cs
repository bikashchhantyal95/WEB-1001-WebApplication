using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Author
{
    [EmailAddress]
    public string Email { get; set; } = String.Empty;

    [Url]
    public Uri? Photo { get; set; }

    [Display(Name = "Full Name")]
    [StringLength(255, MinimumLength = 10)]
    public string FullName { get; set; } = String.Empty;

    [Phone]
    public string PhoneNumber { get; set; } = String.Empty;

    [Range(18, 99)]
    public int Age { get; set; }
}