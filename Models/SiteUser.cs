using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace W21_Assignment.Models;

public class SiteUser : IdentityUser
{
    // public int UserId { get; set; }
    [PersonalData]
    public string? Name { get; set; }
    [PersonalData]
    public string? Email { get; set; }
    [PersonalData]
    public string? Phone { get; set; }
    [PersonalData]
    public int StreetNumber { get; set; } = 1;
    [PersonalData]

    public string? StreetName { get; set; }
    [PersonalData]

    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please type valide postalcode!")]
    public string? PostalCode { get; set; }

    [PersonalData]
    public string? City { get; set; }
    public string? Province { get; set; }
    [PersonalData]
    public UserType UserType { get; set; }

}
public enum UserType
{
    Customer, Employee
}