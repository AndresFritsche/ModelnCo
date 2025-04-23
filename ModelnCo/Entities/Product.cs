
using System.ComponentModel.DataAnnotations;

namespace ModelnCoAPI.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Brand  { get; set; }

    public int Weight { get; set; }

    public string? Dimension { get; set; }

    public string? Category { get; set; }

    public long Price { get; set; }

    public long PictureUrl { get; set; }

    public string? Description { get; set; }

    public int QtyInStock  { get; set; }
}
