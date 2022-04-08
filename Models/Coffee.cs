using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace W21_Assignment.Models;

public class Coffee
{
    public int CoffeeId { get; set; }
    public string? Name { get; set; }

    public string? Picture { get; set; }
    public string? Description { get; set; }

    [Range(0, 20000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(7,2)")]
    public decimal? Price { get; set; } = 1000;
}