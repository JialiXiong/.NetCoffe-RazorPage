using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace W21_Assignment.Models;

public class Menu
{
    public int MenuId { get; set; }
    public string? Main { get; set; }
    public string? Entree { get; set; }
    public Days Day { get; set; }

    [Range(0, 20000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(7,2)")]
    public decimal? Price { get; set; } = 1000;
}
public enum Days
{
    Mon, Tue, Wed, Thu, Fri, Sat, Sun
}