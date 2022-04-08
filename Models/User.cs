using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace W21_Assignment.Models;

public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int StreetNumber { get; set; }

    public string? StreetName { get; set; }

    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please type valide postalcode!")]
    public string? Postalcode { get; set; }
    [Required]
    public string? City { get; set; }
    public string? Province { get; set; }
}