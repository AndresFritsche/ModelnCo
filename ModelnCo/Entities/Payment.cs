using System;
using System.ComponentModel.DataAnnotations;

namespace ModelnCoAPI.Entities;

public class Payment
{
    [Key]
    public int Id { get; set; }

    public int OrderId { get; set; }

    public DateOnly PaymentDate { get; set; }

    public required string PaymentMethod { get; set; }
    
}
