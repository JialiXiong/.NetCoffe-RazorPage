using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W21_Assignment.Model;

public class Customer
{
    public uint CustomerId { get; set; }
    public string Name { get; set; } = "Customer Name";
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
    public string? Email { get; set; }
    public string? Status { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
    public int? StreetNumber { get; set; }
    public string? StreetName { get; set; }

    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in A1A 1A1 format")]
    public string? PostalCode { get; set; }
    public string? City { get; set; }

    public string? Province { get; set; }
    public string? Phone { get; set; }



}