using System;
using System.ComponentModel.DataAnnotations;

namespace ModelnCoAPI.Entities;

public class Category
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
}
