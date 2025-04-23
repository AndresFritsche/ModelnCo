using System;
using System.ComponentModel.DataAnnotations;

namespace ModelnCoAPI.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }
    public int IdCustomer { get; set; }
    public int IdProduct { get; set; }
    public int IdCategory { get; set; }
    public int Quantity { get; set; }
    public int IdPaymnet { get; set; }
}
